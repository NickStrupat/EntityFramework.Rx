using System;
using System.Data.Entity;
using System.Reactive.Linq;

using EntityFramework.Triggers;

namespace EntityFramework.Rx {
	public static class ObservableEntity {
		private static Func<DbContext> dbContextFactory;
		public static void RegisterDbContextFactory<TDbContext>(Func<TDbContext> factory) where TDbContext : DbContext => dbContextFactory = factory;

		public static IObservable<IBeforeEntry<TEntity>> FromInserting<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IBeforeEntry<TEntity>>(action => Triggers<TEntity>.Inserting += entry => {
				using (var context = dbContextFactory())
					action(new Entries<TEntity>.InsertingEntry(entry, context));
			}, action => { });
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
}
