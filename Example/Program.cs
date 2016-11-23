using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading;

using EntityFramework.Rx;
using EntityFramework.Triggers;

namespace Example {
	class Program {
		static void Main(String[] args) {
			var observerThread = new Thread(ObserveNewPeople);
			observerThread.Start();
			Thread.Sleep(100);
			using (var context = new Context()) {
				Console.WriteLine("context");
				context.People.Add(new Person { Name = "Nick", DateOfBirth = new DateTime(1986, 7, 17) });
				context.SaveChanges();
				context.People.Add(new Person { Name = "Joe", DateOfBirth = DateTime.Today });
				context.SaveChanges();
				Console.WriteLine("saved");
			}
			observerThread.Join();
		}

		private static void ObserveNewPeople() {
			Console.WriteLine("thread");
			var o = DbObservable<Context>.FromInserted<Person>();
			using (var p = o.Where(x => x.Entity.DateOfBirth.Month == DateTime.Today.Month && x.Entity.DateOfBirth.Day == DateTime.Today.Day)
			                .Subscribe(entry => Console.WriteLine($"Happy birthday to {entry.Entity.Name}!"))) {
				Thread.Sleep(5000);
			}
		}
	}

	public class Context : DbContextWithTriggers {
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
