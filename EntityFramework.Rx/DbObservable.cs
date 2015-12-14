using System;
using System.Data.Entity;
using System.Reactive.Linq;

using EntityFramework.Triggers;

namespace EntityFramework.Rx {
	public static class DbObservable {
		public static IObservable<IBeforeEntry<TEntity>> FromInserting<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IBeforeEntry<TEntity>>(h => Triggers<TEntity>.Inserting += h, h => Triggers<TEntity>.Inserting -= h);
		}
		public static IObservable<IBeforeChangeEntry<TEntity>> FromUpdating<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IBeforeChangeEntry<TEntity>>(h => Triggers<TEntity>.Updating += h, h => Triggers<TEntity>.Updating -= h);
		}
		public static IObservable<IBeforeChangeEntry<TEntity>> FromDeleting<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IBeforeChangeEntry<TEntity>>(h => Triggers<TEntity>.Deleting += h, h => Triggers<TEntity>.Deleting -= h);
		}
		public static IObservable<IFailedEntry<TEntity>> FromInsertFailed<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IFailedEntry<TEntity>>(h => Triggers<TEntity>.InsertFailed += h, h => Triggers<TEntity>.InsertFailed -= h);
		}
		public static IObservable<IChangeFailedEntry<TEntity>> FromUpdateFailed<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IChangeFailedEntry<TEntity>>(h => Triggers<TEntity>.UpdateFailed += h, h => Triggers<TEntity>.UpdateFailed -= h);
		}
		public static IObservable<IChangeFailedEntry<TEntity>> FromDeleteFailed<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IChangeFailedEntry<TEntity>>(h => Triggers<TEntity>.DeleteFailed += h, h => Triggers<TEntity>.DeleteFailed -= h);
		}
		public static IObservable<IAfterEntry<TEntity>> FromInserted<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IAfterEntry<TEntity>>(h => Triggers<TEntity>.Inserted += h, h => Triggers<TEntity>.Inserted -= h);
		}
		public static IObservable<IAfterChangeEntry<TEntity>> FromUpdated<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IAfterChangeEntry<TEntity>>(h => Triggers<TEntity>.Updated += h, h => Triggers<TEntity>.Updated -= h);
		}
		public static IObservable<IAfterChangeEntry<TEntity>> FromDeleted<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IAfterChangeEntry<TEntity>>(h => Triggers<TEntity>.Deleted += h, h => Triggers<TEntity>.Deleted -= h);
		}
	}

	public static class DbObservable<TDbContext> where TDbContext : DbContext {
		public static IObservable<IBeforeEntry<TEntity, TDbContext>> FromInserting<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IBeforeEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.Inserting += h, h => Triggers<TEntity, TDbContext>.Inserting -= h);
		}
		public static IObservable<IBeforeChangeEntry<TEntity, TDbContext>> FromUpdating<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IBeforeChangeEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.Updating += h, h => Triggers<TEntity, TDbContext>.Updating -= h);
		}
		public static IObservable<IBeforeChangeEntry<TEntity, TDbContext>> FromDeleting<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IBeforeChangeEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.Deleting += h, h => Triggers<TEntity, TDbContext>.Deleting -= h);
		}
		public static IObservable<IFailedEntry<TEntity, TDbContext>> FromInsertFailed<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IFailedEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.InsertFailed += h, h => Triggers<TEntity, TDbContext>.InsertFailed -= h);
		}
		public static IObservable<IChangeFailedEntry<TEntity, TDbContext>> FromUpdateFailed<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IChangeFailedEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.UpdateFailed += h, h => Triggers<TEntity, TDbContext>.UpdateFailed -= h);
		}
		public static IObservable<IChangeFailedEntry<TEntity, TDbContext>> FromDeleteFailed<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IChangeFailedEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.DeleteFailed += h, h => Triggers<TEntity, TDbContext>.DeleteFailed -= h);
		}
		public static IObservable<IAfterEntry<TEntity, TDbContext>> FromInserted<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IAfterEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.Inserted += h, h => Triggers<TEntity, TDbContext>.Inserted -= h);
		}
		public static IObservable<IAfterChangeEntry<TEntity, TDbContext>> FromUpdated<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IAfterChangeEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.Updated += h, h => Triggers<TEntity, TDbContext>.Updated -= h);
		}
		public static IObservable<IAfterChangeEntry<TEntity, TDbContext>> FromDeleted<TEntity>() where TEntity : class, ITriggerable {
			return Observable.FromEvent<IAfterChangeEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.Deleted += h, h => Triggers<TEntity, TDbContext>.Deleted -= h);
		}
	}
}
