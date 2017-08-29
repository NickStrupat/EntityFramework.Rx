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
		    void AddHandler(Action<IBeforeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Inserting += h;
		    void RemoveHandler(Action<IBeforeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Inserting -= h;
		    return Observable.FromEvent<IBeforeEntry<TEntity, DbContext>>(AddHandler, RemoveHandler);
		}
        public static IObservable<IBeforeChangeEntry<TEntity, DbContext>> FromUpdating<TEntity>() where TEntity : class {
		    void AddHandler(Action<IBeforeChangeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Updating += h;
		    void RemoveHandler(Action<IBeforeChangeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Updating -= h;
		    return Observable.FromEvent<IBeforeChangeEntry<TEntity, DbContext>>(AddHandler, RemoveHandler);
		}
        public static IObservable<IBeforeChangeEntry<TEntity, DbContext>> FromDeleting<TEntity>() where TEntity : class {
		    void AddHandler(Action<IBeforeChangeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Deleting += h;
		    void RemoveHandler(Action<IBeforeChangeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Deleting -= h;
		    return Observable.FromEvent<IBeforeChangeEntry<TEntity, DbContext>>(AddHandler, RemoveHandler);
		}
        public static IObservable<IFailedEntry<TEntity, DbContext>> FromInsertFailed<TEntity>() where TEntity : class {
		    void AddHandler(Action<IFailedEntry<TEntity, DbContext>> h) => Triggers<TEntity>.InsertFailed += h;
		    void RemoveHandler(Action<IFailedEntry<TEntity, DbContext>> h) => Triggers<TEntity>.InsertFailed -= h;
		    return Observable.FromEvent<IFailedEntry<TEntity, DbContext>>(AddHandler, RemoveHandler);
		}
        public static IObservable<IChangeFailedEntry<TEntity, DbContext>> FromUpdateFailed<TEntity>() where TEntity : class {
		    void AddHandler(Action<IChangeFailedEntry<TEntity, DbContext>> h) => Triggers<TEntity>.UpdateFailed += h;
		    void RemoveHandler(Action<IChangeFailedEntry<TEntity, DbContext>> h) => Triggers<TEntity>.UpdateFailed -= h;
		    return Observable.FromEvent<IChangeFailedEntry<TEntity, DbContext>>(AddHandler, RemoveHandler);
		}
        public static IObservable<IChangeFailedEntry<TEntity, DbContext>> FromDeleteFailed<TEntity>() where TEntity : class {
		    void AddHandler(Action<IChangeFailedEntry<TEntity, DbContext>> h) => Triggers<TEntity>.DeleteFailed += h;
		    void RemoveHandler(Action<IChangeFailedEntry<TEntity, DbContext>> h) => Triggers<TEntity>.DeleteFailed -= h;
		    return Observable.FromEvent<IChangeFailedEntry<TEntity, DbContext>>(AddHandler, RemoveHandler);
		}
        public static IObservable<IAfterEntry<TEntity, DbContext>> FromInserted<TEntity>() where TEntity : class {
		    void AddHandler(Action<IAfterEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Inserted += h;
		    void RemoveHandler(Action<IAfterEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Inserted -= h;
		    return Observable.FromEvent<IAfterEntry<TEntity, DbContext>>(AddHandler, RemoveHandler);
		}
        public static IObservable<IAfterChangeEntry<TEntity, DbContext>> FromUpdated<TEntity>() where TEntity : class {
		    void AddHandler(Action<IAfterChangeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Updated += h;
		    void RemoveHandler(Action<IAfterChangeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Updated -= h;
		    return Observable.FromEvent<IAfterChangeEntry<TEntity, DbContext>>(AddHandler, RemoveHandler);
		}
        public static IObservable<IAfterChangeEntry<TEntity, DbContext>> FromDeleted<TEntity>() where TEntity : class {
		    void AddHandler(Action<IAfterChangeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Deleted += h;
		    void RemoveHandler(Action<IAfterChangeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Deleted -= h;
		    return Observable.FromEvent<IAfterChangeEntry<TEntity, DbContext>>(AddHandler, RemoveHandler);
		}

		public static IObservable<IBeforeEntry<TEntity, DbContext>> FromInserting<TEntity>(IScheduler scheduler) where TEntity : class {
		    void AddHandler(Action<IBeforeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Inserting += h;
		    void RemoveHandler(Action<IBeforeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Inserting -= h;
		    return Observable.FromEvent<IBeforeEntry<TEntity, DbContext>>(AddHandler, RemoveHandler, scheduler);
		}
		public static IObservable<IBeforeChangeEntry<TEntity, DbContext>> FromUpdating<TEntity>(IScheduler scheduler) where TEntity : class {
		    void AddHandler(Action<IBeforeChangeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Updating += h;
		    void RemoveHandler(Action<IBeforeChangeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Updating -= h;
		    return Observable.FromEvent<IBeforeChangeEntry<TEntity, DbContext>>(AddHandler, RemoveHandler, scheduler);
		}
		public static IObservable<IBeforeChangeEntry<TEntity, DbContext>> FromDeleting<TEntity>(IScheduler scheduler) where TEntity : class {
		    void AddHandler(Action<IBeforeChangeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Deleting += h;
		    void RemoveHandler(Action<IBeforeChangeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Deleting -= h;
		    return Observable.FromEvent<IBeforeChangeEntry<TEntity, DbContext>>(AddHandler, RemoveHandler, scheduler);
		}
		public static IObservable<IFailedEntry<TEntity, DbContext>> FromInsertFailed<TEntity>(IScheduler scheduler) where TEntity : class {
		    void AddHandler(Action<IFailedEntry<TEntity, DbContext>> h) => Triggers<TEntity>.InsertFailed += h;
		    void RemoveHandler(Action<IFailedEntry<TEntity, DbContext>> h) => Triggers<TEntity>.InsertFailed -= h;
		    return Observable.FromEvent<IFailedEntry<TEntity, DbContext>>(AddHandler, RemoveHandler, scheduler);
		}
		public static IObservable<IChangeFailedEntry<TEntity, DbContext>> FromUpdateFailed<TEntity>(IScheduler scheduler) where TEntity : class {
		    void AddHandler(Action<IChangeFailedEntry<TEntity, DbContext>> h) => Triggers<TEntity>.UpdateFailed += h;
		    void RemoveHandler(Action<IChangeFailedEntry<TEntity, DbContext>> h) => Triggers<TEntity>.UpdateFailed -= h;
		    return Observable.FromEvent<IChangeFailedEntry<TEntity, DbContext>>(AddHandler, RemoveHandler, scheduler);
		}
		public static IObservable<IChangeFailedEntry<TEntity, DbContext>> FromDeleteFailed<TEntity>(IScheduler scheduler) where TEntity : class {
		    void AddHandler(Action<IChangeFailedEntry<TEntity, DbContext>> h) => Triggers<TEntity>.DeleteFailed += h;
		    void RemoveHandler(Action<IChangeFailedEntry<TEntity, DbContext>> h) => Triggers<TEntity>.DeleteFailed -= h;
		    return Observable.FromEvent<IChangeFailedEntry<TEntity, DbContext>>(AddHandler, RemoveHandler, scheduler);
		}
		public static IObservable<IAfterEntry<TEntity, DbContext>> FromInserted<TEntity>(IScheduler scheduler) where TEntity : class {
		    void AddHandler(Action<IAfterEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Inserted += h;
		    void RemoveHandler(Action<IAfterEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Inserted -= h;
		    return Observable.FromEvent<IAfterEntry<TEntity, DbContext>>(AddHandler, RemoveHandler, scheduler);
		}
		public static IObservable<IAfterChangeEntry<TEntity, DbContext>> FromUpdated<TEntity>(IScheduler scheduler) where TEntity : class {
		    void AddHandler(Action<IAfterChangeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Updated += h;
		    void RemoveHandler(Action<IAfterChangeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Updated -= h;
		    return Observable.FromEvent<IAfterChangeEntry<TEntity, DbContext>>(AddHandler, RemoveHandler, scheduler);
		}
		public static IObservable<IAfterChangeEntry<TEntity, DbContext>> FromDeleted<TEntity>(IScheduler scheduler) where TEntity : class {
		    void AddHandler(Action<IAfterChangeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Deleted += h;
		    void RemoveHandler(Action<IAfterChangeEntry<TEntity, DbContext>> h) => Triggers<TEntity>.Deleted -= h;
		    return Observable.FromEvent<IAfterChangeEntry<TEntity, DbContext>>(AddHandler, RemoveHandler, scheduler);
		}
	}

	public static class DbObservable<TDbContext> where TDbContext : DbContext {
		public static IObservable<IBeforeEntry<TEntity, TDbContext>> FromInserting<TEntity>() where TEntity : class {
		    void AddHandler(Action<IBeforeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Inserting += h;
		    void RemoveHandler(Action<IBeforeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Inserting -= h;
		    return Observable.FromEvent<IBeforeEntry<TEntity, TDbContext>>(AddHandler, RemoveHandler);
		}
		public static IObservable<IBeforeChangeEntry<TEntity, TDbContext>> FromUpdating<TEntity>() where TEntity : class {
		    void AddHandler(Action<IBeforeChangeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Updating += h;
		    void RemoveHandler(Action<IBeforeChangeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Updating -= h;
		    return Observable.FromEvent<IBeforeChangeEntry<TEntity, TDbContext>>(AddHandler, RemoveHandler);
		}
		public static IObservable<IBeforeChangeEntry<TEntity, TDbContext>> FromDeleting<TEntity>() where TEntity : class {
		    void AddHandler(Action<IBeforeChangeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Deleting += h;
		    void RemoveHandler(Action<IBeforeChangeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Deleting -= h;
		    return Observable.FromEvent<IBeforeChangeEntry<TEntity, TDbContext>>(AddHandler, RemoveHandler);
		}
		public static IObservable<IFailedEntry<TEntity, TDbContext>> FromInsertFailed<TEntity>() where TEntity : class {
		    void AddHandler(Action<IFailedEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.InsertFailed += h;
		    void RemoveHandler(Action<IFailedEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.InsertFailed -= h;
		    return Observable.FromEvent<IFailedEntry<TEntity, TDbContext>>(AddHandler, RemoveHandler);
		}
		public static IObservable<IChangeFailedEntry<TEntity, TDbContext>> FromUpdateFailed<TEntity>() where TEntity : class {
		    void AddHandler(Action<IChangeFailedEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.UpdateFailed += h;
		    void RemoveHandler(Action<IChangeFailedEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.UpdateFailed -= h;
		    return Observable.FromEvent<IChangeFailedEntry<TEntity, TDbContext>>(AddHandler, RemoveHandler);
		}
		public static IObservable<IChangeFailedEntry<TEntity, TDbContext>> FromDeleteFailed<TEntity>() where TEntity : class {
		    void AddHandler(Action<IChangeFailedEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.DeleteFailed += h;
		    void RemoveHandler(Action<IChangeFailedEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.DeleteFailed -= h;
		    return Observable.FromEvent<IChangeFailedEntry<TEntity, TDbContext>>(AddHandler, RemoveHandler);
		}
		public static IObservable<IAfterEntry<TEntity, TDbContext>> FromInserted<TEntity>() where TEntity : class {
		    void AddHandler(Action<IAfterEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Inserted += h;
		    void RemoveHandler(Action<IAfterEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Inserted -= h;
		    return Observable.FromEvent<IAfterEntry<TEntity, TDbContext>>(AddHandler, RemoveHandler);
		}
		public static IObservable<IAfterChangeEntry<TEntity, TDbContext>> FromUpdated<TEntity>() where TEntity : class {
		    void AddHandler(Action<IAfterChangeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Updated += h;
		    void RemoveHandler(Action<IAfterChangeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Updated -= h;
		    return Observable.FromEvent<IAfterChangeEntry<TEntity, TDbContext>>(AddHandler, RemoveHandler);
		}
		public static IObservable<IAfterChangeEntry<TEntity, TDbContext>> FromDeleted<TEntity>() where TEntity : class {
		    void AddHandler(Action<IAfterChangeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Deleted += h;
		    void RemoveHandler(Action<IAfterChangeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Deleted -= h;
		    return Observable.FromEvent<IAfterChangeEntry<TEntity, TDbContext>>(AddHandler, RemoveHandler);
		}

		public static IObservable<IBeforeEntry<TEntity, TDbContext>> FromInserting<TEntity>(IScheduler scheduler) where TEntity : class {
		    void AddHandler(Action<IBeforeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Inserting += h;
		    void RemoveHandler(Action<IBeforeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Inserting -= h;
		    return Observable.FromEvent<IBeforeEntry<TEntity, TDbContext>>(AddHandler, RemoveHandler, scheduler);
		}
		public static IObservable<IBeforeChangeEntry<TEntity, TDbContext>> FromUpdating<TEntity>(IScheduler scheduler) where TEntity : class {
		    void AddHandler(Action<IBeforeChangeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Updating += h;
		    void RemoveHandler(Action<IBeforeChangeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Updating -= h;
		    return Observable.FromEvent<IBeforeChangeEntry<TEntity, TDbContext>>(AddHandler, RemoveHandler, scheduler);
		}
		public static IObservable<IBeforeChangeEntry<TEntity, TDbContext>> FromDeleting<TEntity>(IScheduler scheduler) where TEntity : class {
		    void AddHandler(Action<IBeforeChangeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Deleting += h;
		    void RemoveHandler(Action<IBeforeChangeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Deleting -= h;
		    return Observable.FromEvent<IBeforeChangeEntry<TEntity, TDbContext>>(AddHandler, RemoveHandler, scheduler);
		}
		public static IObservable<IFailedEntry<TEntity, TDbContext>> FromInsertFailed<TEntity>(IScheduler scheduler) where TEntity : class {
		    void AddHandler(Action<IFailedEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.InsertFailed += h;
		    void RemoveHandler(Action<IFailedEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.InsertFailed -= h;
		    return Observable.FromEvent<IFailedEntry<TEntity, TDbContext>>(AddHandler, RemoveHandler, scheduler);
		}
		public static IObservable<IChangeFailedEntry<TEntity, TDbContext>> FromUpdateFailed<TEntity>(IScheduler scheduler) where TEntity : class {
		    void AddHandler(Action<IChangeFailedEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.UpdateFailed += h;
		    void RemoveHandler(Action<IChangeFailedEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.UpdateFailed -= h;
		    return Observable.FromEvent<IChangeFailedEntry<TEntity, TDbContext>>(AddHandler, RemoveHandler, scheduler);
		}
		public static IObservable<IChangeFailedEntry<TEntity, TDbContext>> FromDeleteFailed<TEntity>(IScheduler scheduler) where TEntity : class {
		    void AddHandler(Action<IChangeFailedEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.DeleteFailed += h;
		    void RemoveHandler(Action<IChangeFailedEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.DeleteFailed -= h;
		    return Observable.FromEvent<IChangeFailedEntry<TEntity, TDbContext>>(AddHandler, RemoveHandler, scheduler);
		}
		public static IObservable<IAfterEntry<TEntity, TDbContext>> FromInserted<TEntity>(IScheduler scheduler) where TEntity : class {
		    void AddHandler(Action<IAfterEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Inserted += h;
		    void RemoveHandler(Action<IAfterEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Inserted -= h;
		    return Observable.FromEvent<IAfterEntry<TEntity, TDbContext>>(AddHandler, RemoveHandler, scheduler);
		}
		public static IObservable<IAfterChangeEntry<TEntity, TDbContext>> FromUpdated<TEntity>(IScheduler scheduler) where TEntity : class {
		    void AddHandler(Action<IAfterChangeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Updated += h;
		    void RemoveHandler(Action<IAfterChangeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Updated -= h;
		    return Observable.FromEvent<IAfterChangeEntry<TEntity, TDbContext>>(AddHandler, RemoveHandler, scheduler);
		}
		public static IObservable<IAfterChangeEntry<TEntity, TDbContext>> FromDeleted<TEntity>(IScheduler scheduler) where TEntity : class {
		    void AddHandler(Action<IAfterChangeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Deleted += h;
		    void RemoveHandler(Action<IAfterChangeEntry<TEntity, TDbContext>> h) => Triggers<TEntity, TDbContext>.Deleted -= h;
		    return Observable.FromEvent<IAfterChangeEntry<TEntity, TDbContext>>(AddHandler, RemoveHandler, scheduler);
		}
	}
}
