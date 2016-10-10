using System;
using System.Reactive.Concurrency;
using System.Reactive.Linq;

#if EF_CORE
using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;
namespace EntityFrameworkCore.Rx {
#else
using System.Data.Entity;
using EntityFramework.Triggers;
namespace EntityFramework.Rx {
#endif
	public static class DbObservable {
		public static IObservable<IBeforeEntry<TEntity, DbContext>> FromInserting<TEntity>() where TEntity : class {
			return Observable.FromEvent<IBeforeEntry<TEntity, DbContext>>(h => Triggers<TEntity>.Inserting += h, h => Triggers<TEntity>.Inserting -= h);
		}
		public static IObservable<IBeforeChangeEntry<TEntity, DbContext>> FromUpdating<TEntity>() where TEntity : class {
			return Observable.FromEvent<IBeforeChangeEntry<TEntity, DbContext>>(h => Triggers<TEntity>.Updating += h, h => Triggers<TEntity>.Updating -= h);
		}
		public static IObservable<IBeforeChangeEntry<TEntity, DbContext>> FromDeleting<TEntity>() where TEntity : class {
			return Observable.FromEvent<IBeforeChangeEntry<TEntity, DbContext>>(h => Triggers<TEntity>.Deleting += h, h => Triggers<TEntity>.Deleting -= h);
		}
		public static IObservable<IFailedEntry<TEntity, DbContext>> FromInsertFailed<TEntity>() where TEntity : class {
			return Observable.FromEvent<IFailedEntry<TEntity, DbContext>>(h => Triggers<TEntity>.InsertFailed += h, h => Triggers<TEntity>.InsertFailed -= h);
		}
		public static IObservable<IChangeFailedEntry<TEntity, DbContext>> FromUpdateFailed<TEntity>() where TEntity : class {
			return Observable.FromEvent<IChangeFailedEntry<TEntity, DbContext>>(h => Triggers<TEntity>.UpdateFailed += h, h => Triggers<TEntity>.UpdateFailed -= h);
		}
		public static IObservable<IChangeFailedEntry<TEntity, DbContext>> FromDeleteFailed<TEntity>() where TEntity : class {
			return Observable.FromEvent<IChangeFailedEntry<TEntity, DbContext>>(h => Triggers<TEntity>.DeleteFailed += h, h => Triggers<TEntity>.DeleteFailed -= h);
		}
		public static IObservable<IAfterEntry<TEntity, DbContext>> FromInserted<TEntity>() where TEntity : class {
			return Observable.FromEvent<IAfterEntry<TEntity, DbContext>>(h => Triggers<TEntity>.Inserted += h, h => Triggers<TEntity>.Inserted -= h);
		}
		public static IObservable<IAfterChangeEntry<TEntity, DbContext>> FromUpdated<TEntity>() where TEntity : class {
			return Observable.FromEvent<IAfterChangeEntry<TEntity, DbContext>>(h => Triggers<TEntity>.Updated += h, h => Triggers<TEntity>.Updated -= h);
		}
		public static IObservable<IAfterChangeEntry<TEntity, DbContext>> FromDeleted<TEntity>() where TEntity : class {
			return Observable.FromEvent<IAfterChangeEntry<TEntity, DbContext>>(h => Triggers<TEntity>.Deleted += h, h => Triggers<TEntity>.Deleted -= h);
		}

		public static IObservable<IBeforeEntry<TEntity, DbContext>> FromInserting<TEntity>(IScheduler scheduler) where TEntity : class {
			return Observable.FromEvent<IBeforeEntry<TEntity, DbContext>>(h => Triggers<TEntity>.Inserting += h, h => Triggers<TEntity>.Inserting -= h, scheduler);
		}
		public static IObservable<IBeforeChangeEntry<TEntity, DbContext>> FromUpdating<TEntity>(IScheduler scheduler) where TEntity : class {
			return Observable.FromEvent<IBeforeChangeEntry<TEntity, DbContext>>(h => Triggers<TEntity>.Updating += h, h => Triggers<TEntity>.Updating -= h, scheduler);
		}
		public static IObservable<IBeforeChangeEntry<TEntity, DbContext>> FromDeleting<TEntity>(IScheduler scheduler) where TEntity : class {
			return Observable.FromEvent<IBeforeChangeEntry<TEntity, DbContext>>(h => Triggers<TEntity>.Deleting += h, h => Triggers<TEntity>.Deleting -= h, scheduler);
		}
		public static IObservable<IFailedEntry<TEntity, DbContext>> FromInsertFailed<TEntity>(IScheduler scheduler) where TEntity : class {
			return Observable.FromEvent<IFailedEntry<TEntity, DbContext>>(h => Triggers<TEntity>.InsertFailed += h, h => Triggers<TEntity>.InsertFailed -= h, scheduler);
		}
		public static IObservable<IChangeFailedEntry<TEntity, DbContext>> FromUpdateFailed<TEntity>(IScheduler scheduler) where TEntity : class {
			return Observable.FromEvent<IChangeFailedEntry<TEntity, DbContext>>(h => Triggers<TEntity>.UpdateFailed += h, h => Triggers<TEntity>.UpdateFailed -= h, scheduler);
		}
		public static IObservable<IChangeFailedEntry<TEntity, DbContext>> FromDeleteFailed<TEntity>(IScheduler scheduler) where TEntity : class {
			return Observable.FromEvent<IChangeFailedEntry<TEntity, DbContext>>(h => Triggers<TEntity>.DeleteFailed += h, h => Triggers<TEntity>.DeleteFailed -= h, scheduler);
		}
		public static IObservable<IAfterEntry<TEntity, DbContext>> FromInserted<TEntity>(IScheduler scheduler) where TEntity : class {
			return Observable.FromEvent<IAfterEntry<TEntity, DbContext>>(h => Triggers<TEntity>.Inserted += h, h => Triggers<TEntity>.Inserted -= h, scheduler);
		}
		public static IObservable<IAfterChangeEntry<TEntity, DbContext>> FromUpdated<TEntity>(IScheduler scheduler) where TEntity : class {
			return Observable.FromEvent<IAfterChangeEntry<TEntity, DbContext>>(h => Triggers<TEntity>.Updated += h, h => Triggers<TEntity>.Updated -= h, scheduler);
		}
		public static IObservable<IAfterChangeEntry<TEntity, DbContext>> FromDeleted<TEntity>(IScheduler scheduler) where TEntity : class {
			return Observable.FromEvent<IAfterChangeEntry<TEntity, DbContext>>(h => Triggers<TEntity>.Deleted += h, h => Triggers<TEntity>.Deleted -= h, scheduler);
		}
	}

	public static class DbObservable<TDbContext> where TDbContext : DbContext {
		public static IObservable<IBeforeEntry<TEntity, TDbContext>> FromInserting<TEntity>() where TEntity : class {
			return Observable.FromEvent<IBeforeEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.Inserting += h, h => Triggers<TEntity, TDbContext>.Inserting -= h);
		}
		public static IObservable<IBeforeChangeEntry<TEntity, TDbContext>> FromUpdating<TEntity>() where TEntity : class {
			return Observable.FromEvent<IBeforeChangeEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.Updating += h, h => Triggers<TEntity, TDbContext>.Updating -= h);
		}
		public static IObservable<IBeforeChangeEntry<TEntity, TDbContext>> FromDeleting<TEntity>() where TEntity : class {
			return Observable.FromEvent<IBeforeChangeEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.Deleting += h, h => Triggers<TEntity, TDbContext>.Deleting -= h);
		}
		public static IObservable<IFailedEntry<TEntity, TDbContext>> FromInsertFailed<TEntity>() where TEntity : class {
			return Observable.FromEvent<IFailedEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.InsertFailed += h, h => Triggers<TEntity, TDbContext>.InsertFailed -= h);
		}
		public static IObservable<IChangeFailedEntry<TEntity, TDbContext>> FromUpdateFailed<TEntity>() where TEntity : class {
			return Observable.FromEvent<IChangeFailedEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.UpdateFailed += h, h => Triggers<TEntity, TDbContext>.UpdateFailed -= h);
		}
		public static IObservable<IChangeFailedEntry<TEntity, TDbContext>> FromDeleteFailed<TEntity>() where TEntity : class {
			return Observable.FromEvent<IChangeFailedEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.DeleteFailed += h, h => Triggers<TEntity, TDbContext>.DeleteFailed -= h);
		}
		public static IObservable<IAfterEntry<TEntity, TDbContext>> FromInserted<TEntity>() where TEntity : class {
			return Observable.FromEvent<IAfterEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.Inserted += h, h => Triggers<TEntity, TDbContext>.Inserted -= h);
		}
		public static IObservable<IAfterChangeEntry<TEntity, TDbContext>> FromUpdated<TEntity>() where TEntity : class {
			return Observable.FromEvent<IAfterChangeEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.Updated += h, h => Triggers<TEntity, TDbContext>.Updated -= h);
		}
		public static IObservable<IAfterChangeEntry<TEntity, TDbContext>> FromDeleted<TEntity>() where TEntity : class {
			return Observable.FromEvent<IAfterChangeEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.Deleted += h, h => Triggers<TEntity, TDbContext>.Deleted -= h);
		}

		public static IObservable<IBeforeEntry<TEntity, TDbContext>> FromInserting<TEntity>(IScheduler scheduler) where TEntity : class {
			return Observable.FromEvent<IBeforeEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.Inserting += h, h => Triggers<TEntity, TDbContext>.Inserting -= h, scheduler);
		}
		public static IObservable<IBeforeChangeEntry<TEntity, TDbContext>> FromUpdating<TEntity>(IScheduler scheduler) where TEntity : class {
			return Observable.FromEvent<IBeforeChangeEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.Updating += h, h => Triggers<TEntity, TDbContext>.Updating -= h, scheduler);
		}
		public static IObservable<IBeforeChangeEntry<TEntity, TDbContext>> FromDeleting<TEntity>(IScheduler scheduler) where TEntity : class {
			return Observable.FromEvent<IBeforeChangeEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.Deleting += h, h => Triggers<TEntity, TDbContext>.Deleting -= h, scheduler);
		}
		public static IObservable<IFailedEntry<TEntity, TDbContext>> FromInsertFailed<TEntity>(IScheduler scheduler) where TEntity : class {
			return Observable.FromEvent<IFailedEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.InsertFailed += h, h => Triggers<TEntity, TDbContext>.InsertFailed -= h, scheduler);
		}
		public static IObservable<IChangeFailedEntry<TEntity, TDbContext>> FromUpdateFailed<TEntity>(IScheduler scheduler) where TEntity : class {
			return Observable.FromEvent<IChangeFailedEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.UpdateFailed += h, h => Triggers<TEntity, TDbContext>.UpdateFailed -= h, scheduler);
		}
		public static IObservable<IChangeFailedEntry<TEntity, TDbContext>> FromDeleteFailed<TEntity>(IScheduler scheduler) where TEntity : class {
			return Observable.FromEvent<IChangeFailedEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.DeleteFailed += h, h => Triggers<TEntity, TDbContext>.DeleteFailed -= h, scheduler);
		}
		public static IObservable<IAfterEntry<TEntity, TDbContext>> FromInserted<TEntity>(IScheduler scheduler) where TEntity : class {
			return Observable.FromEvent<IAfterEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.Inserted += h, h => Triggers<TEntity, TDbContext>.Inserted -= h, scheduler);
		}
		public static IObservable<IAfterChangeEntry<TEntity, TDbContext>> FromUpdated<TEntity>(IScheduler scheduler) where TEntity : class {
			return Observable.FromEvent<IAfterChangeEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.Updated += h, h => Triggers<TEntity, TDbContext>.Updated -= h, scheduler);
		}
		public static IObservable<IAfterChangeEntry<TEntity, TDbContext>> FromDeleted<TEntity>(IScheduler scheduler) where TEntity : class {
			return Observable.FromEvent<IAfterChangeEntry<TEntity, TDbContext>>(h => Triggers<TEntity, TDbContext>.Deleted += h, h => Triggers<TEntity, TDbContext>.Deleted -= h, scheduler);
		}
	}
}
