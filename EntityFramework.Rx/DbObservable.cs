using System;
using System.Data.Entity;
using System.Linq;
using System.Reactive.Linq;
using System.Reflection;

using EntityFramework.Triggers;

namespace EntityFramework.Rx {
	public static class DbObservable {
		public static IObservable<IBeforeEntry<TEntity>> FromInserting<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IBeforeEntry<TEntity>>(action => Triggers<TEntity>.Inserting += action, action => Triggers<TEntity>.Inserting -= action);
		}
		public static IObservable<IBeforeEntry<TEntity>> FromUpdating<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IBeforeEntry<TEntity>>(action => Triggers<TEntity>.Updating += action, action => Triggers<TEntity>.Updating -= action);
		}
		public static IObservable<IBeforeEntry<TEntity>> FromDeleting<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IBeforeEntry<TEntity>>(action => Triggers<TEntity>.Deleting += action, action => Triggers<TEntity>.Deleting -= action);
		}
		public static IObservable<IFailedEntry<TEntity>> FromInsertFailed<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IFailedEntry<TEntity>>(action => Triggers<TEntity>.InsertFailed += action, action => Triggers<TEntity>.InsertFailed -= action);
		}
		public static IObservable<IFailedEntry<TEntity>> FromUpdateFailed<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IFailedEntry<TEntity>>(action => Triggers<TEntity>.UpdateFailed += action, action => Triggers<TEntity>.UpdateFailed -= action);
		}
		public static IObservable<IFailedEntry<TEntity>> FromDeleteFailed<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IFailedEntry<TEntity>>(action => Triggers<TEntity>.DeleteFailed += action, action => Triggers<TEntity>.DeleteFailed -= action);
		}
		public static IObservable<IEntry<TEntity>> FromInserted<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IEntry<TEntity>>(action => Triggers<TEntity>.Inserted += action, action => Triggers<TEntity>.Inserted -= action);
		}
		public static IObservable<IEntry<TEntity>> FromUpdated<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IEntry<TEntity>>(action => Triggers<TEntity>.Updated += action, action => Triggers<TEntity>.Updated -= action);
		}
		public static IObservable<IEntry<TEntity>> FromDeleted<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IEntry<TEntity>>(action => Triggers<TEntity>.Deleted += action, action => Triggers<TEntity>.Deleted -= action);
		}
	}

	public static class DbObservable<TDbContext> where TDbContext : DbContext {
		public static IObservable<IBeforeEntry<TEntity>> FromInserting<TEntity>() where TEntity : class, ITriggerable {
			CheckThat<TEntity>.IsUsedInTDbContext();
			return DbObservable.FromInserting<TEntity>().Where(IsTDbContext);
		}
		public static IObservable<IBeforeEntry<TEntity>> FromUpdating<TEntity>() where TEntity : class, ITriggerable {
			CheckThat<TEntity>.IsUsedInTDbContext();
			return DbObservable.FromUpdating<TEntity>().Where(IsTDbContext);
		}
		public static IObservable<IBeforeEntry<TEntity>> FromDeleting<TEntity>() where TEntity : class, ITriggerable {
			CheckThat<TEntity>.IsUsedInTDbContext();
			return DbObservable.FromDeleting<TEntity>().Where(IsTDbContext);
		}
		public static IObservable<IFailedEntry<TEntity>> FromInsertFailed<TEntity>() where TEntity : class, ITriggerable {
			CheckThat<TEntity>.IsUsedInTDbContext();
			return DbObservable.FromInsertFailed<TEntity>().Where(IsTDbContext);
		}
		public static IObservable<IFailedEntry<TEntity>> FromUpdateFailed<TEntity>() where TEntity : class, ITriggerable {
			CheckThat<TEntity>.IsUsedInTDbContext();
			return DbObservable.FromUpdateFailed<TEntity>().Where(IsTDbContext);
		}
		public static IObservable<IFailedEntry<TEntity>> FromDeleteFailed<TEntity>() where TEntity : class, ITriggerable {
			CheckThat<TEntity>.IsUsedInTDbContext();
			return DbObservable.FromDeleteFailed<TEntity>().Where(IsTDbContext);
		}
		public static IObservable<IEntry<TEntity>> FromInserted<TEntity>() where TEntity : class, ITriggerable {
			CheckThat<TEntity>.IsUsedInTDbContext();
			return DbObservable.FromInserted<TEntity>().Where(IsTDbContext);
		}
		public static IObservable<IEntry<TEntity>> FromUpdated<TEntity>() where TEntity : class, ITriggerable {
			CheckThat<TEntity>.IsUsedInTDbContext();
			return DbObservable.FromUpdated<TEntity>().Where(IsTDbContext);
		}
		public static IObservable<IEntry<TEntity>> FromDeleted<TEntity>() where TEntity : class, ITriggerable {
			CheckThat<TEntity>.IsUsedInTDbContext();
			return DbObservable.FromDeleted<TEntity>().Where(IsTDbContext);
		}

		private static Boolean IsTDbContext<TEntity>(IEntry<TEntity> entry) where TEntity : class, ITriggerable => entry.Context is TDbContext;

		private static class CheckThat<TEntity> where TEntity : class, ITriggerable {
			private static readonly Boolean DbContextContainsEntity = typeof(TDbContext).GetProperties(BindingFlags.Public | BindingFlags.Instance).Any(x => x.PropertyType == typeof(DbSet<>).MakeGenericType(typeof(TEntity)));

			public static void IsUsedInTDbContext() {
				if (!DbContextContainsEntity)
					throw new InvalidOperationException();
			}
		}
	}
}
