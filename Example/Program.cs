using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EntityFramework.Rx;
using EntityFramework.Triggers;
using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;

namespace Example {
	class Program
	{
		private static readonly ManualResetEventSlim manualResetEventSlim = new ManualResetEventSlim(false);
		static void Main(String[] args) {
			var observerThread = new Thread(ObserveNewPeople);
			observerThread.Start();
			Thread.Sleep(100);
			using (var container = new Container())
			{
				container.Register<IServiceProvider>(() => container, Lifestyle.Singleton);
				container.Register<Context>(Lifestyle.Transient);
				container.Register<Foo>(Lifestyle.Transient);

				var context = container.GetService<Context>();
				Console.WriteLine("context");
				context.People.Add(new Person { Name = "Nick", DateOfBirth = new DateTime(1986, 7, 17) });
				context.SaveChanges();
				context.People.Add(new Person { Name = "Joe", DateOfBirth = DateTime.Today });
				context.SaveChanges();
				Console.WriteLine("saved");
			}
			manualResetEventSlim.Set();
			observerThread.Join();
		}

		private static void ObserveNewPeople() {
			Console.WriteLine("thread");
			var o = DbObservable<Person, Context>.FromInserted<Foo>();
			using (var p = o.Where(x => x.Entity.DateOfBirth.Month == DateTime.Today.Month && x.Entity.DateOfBirth.Day == DateTime.Today.Day)
			                .Subscribe(x => Console.WriteLine($"Happy birthday to {x.Entity.Name}!")))
			{
				manualResetEventSlim.Wait();
			}
		}
	}

	public class Foo
	{
		private static Int32 instanceCount;
		public readonly Int32 Count;
		public Foo() => Count = instanceCount++;
	}

	public class Context : DbContextWithTriggers {
		public Context(IServiceProvider serviceProvider) : base(serviceProvider) {}

		public virtual DbSet<Person> People { get; set; }
	}

	public abstract class Trackable {
		public DateTime Inserted { get; protected set; }
		public DateTime Updated { get; protected set; }

		static Trackable() {
			Triggers<Trackable>.Inserting += e => e.Entity.Inserted = e.Entity.Updated = DateTime.UtcNow;
			Triggers<Trackable>.Updating += e => e.Entity.Updated = DateTime.UtcNow;
		}
	}

	public class Person : Trackable {
		public Int64 Id { get; private set; }
		public String Name { get; set; }
		[DataType(DataType.Date)]
		public DateTime DateOfBirth { get; set; }
	}
}
