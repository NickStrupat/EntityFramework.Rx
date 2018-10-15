using System;
using System.Reactive.Concurrency;
using System.Reactive.Linq;

#if EF_CORE
using EntityFrameworkCore.Triggers;
using Microsoft.EntityFrameworkCore;
namespace EntityFrameworkCore.Rx
#else
using System.Data.Entity;
using EntityFramework.Triggers;
namespace EntityFramework.Rx
#endif
{
	public sealed class DbObservable
	: IDbObservable
	{
		private readonly ITriggers<Object, DbContext> triggers;
		public DbObservable(ITriggers<Object, DbContext> triggers) => this.triggers = triggers;

		public static IObservable<IInsertingEntry<Object, DbContext>> FromInserting() =>
			DbObservable<Object>.FromInserting();
		public static IObservable<IInsertingEntry<Object, DbContext>> FromInserting(IScheduler scheduler) =>
			DbObservable<Object>.FromInserting();

		IObservable<IInsertingEntry<Object, DbContext>> IDbObservable.FromInserting() =>
			DbObservable<Object>.FromInserting();
		IObservable<IInsertingEntry<Object, DbContext>> IDbObservable.FromInserting(IScheduler scheduler) =>
			DbObservable<Object>.FromInserting();

		public static IObservable<IInsertFailedEntry<Object, DbContext>> FromInsertFailed() =>
			DbObservable<Object>.FromInsertFailed();
		public static IObservable<IInsertFailedEntry<Object, DbContext>> FromInsertFailed(IScheduler scheduler) =>
			DbObservable<Object>.FromInsertFailed();

		IObservable<IInsertFailedEntry<Object, DbContext>> IDbObservable.FromInsertFailed() =>
			DbObservable<Object>.FromInsertFailed();
		IObservable<IInsertFailedEntry<Object, DbContext>> IDbObservable.FromInsertFailed(IScheduler scheduler) =>
			DbObservable<Object>.FromInsertFailed();

		public static IObservable<IInsertedEntry<Object, DbContext>> FromInserted() =>
			DbObservable<Object>.FromInserted();
		public static IObservable<IInsertedEntry<Object, DbContext>> FromInserted(IScheduler scheduler) =>
			DbObservable<Object>.FromInserted();

		IObservable<IInsertedEntry<Object, DbContext>> IDbObservable.FromInserted() =>
			DbObservable<Object>.FromInserted();
		IObservable<IInsertedEntry<Object, DbContext>> IDbObservable.FromInserted(IScheduler scheduler) =>
			DbObservable<Object>.FromInserted();

		public static IObservable<IDeletingEntry<Object, DbContext>> FromDeleting() =>
			DbObservable<Object>.FromDeleting();
		public static IObservable<IDeletingEntry<Object, DbContext>> FromDeleting(IScheduler scheduler) =>
			DbObservable<Object>.FromDeleting();

		IObservable<IDeletingEntry<Object, DbContext>> IDbObservable.FromDeleting() =>
			DbObservable<Object>.FromDeleting();
		IObservable<IDeletingEntry<Object, DbContext>> IDbObservable.FromDeleting(IScheduler scheduler) =>
			DbObservable<Object>.FromDeleting();

		public static IObservable<IDeleteFailedEntry<Object, DbContext>> FromDeleteFailed() =>
			DbObservable<Object>.FromDeleteFailed();
		public static IObservable<IDeleteFailedEntry<Object, DbContext>> FromDeleteFailed(IScheduler scheduler) =>
			DbObservable<Object>.FromDeleteFailed();

		IObservable<IDeleteFailedEntry<Object, DbContext>> IDbObservable.FromDeleteFailed() =>
			DbObservable<Object>.FromDeleteFailed();
		IObservable<IDeleteFailedEntry<Object, DbContext>> IDbObservable.FromDeleteFailed(IScheduler scheduler) =>
			DbObservable<Object>.FromDeleteFailed();

		public static IObservable<IDeletedEntry<Object, DbContext>> FromDeleted() =>
			DbObservable<Object>.FromDeleted();
		public static IObservable<IDeletedEntry<Object, DbContext>> FromDeleted(IScheduler scheduler) =>
			DbObservable<Object>.FromDeleted();

		IObservable<IDeletedEntry<Object, DbContext>> IDbObservable.FromDeleted() =>
			DbObservable<Object>.FromDeleted();
		IObservable<IDeletedEntry<Object, DbContext>> IDbObservable.FromDeleted(IScheduler scheduler) =>
			DbObservable<Object>.FromDeleted();

		public static IObservable<IUpdatingEntry<Object, DbContext>> FromUpdating() =>
			DbObservable<Object>.FromUpdating();
		public static IObservable<IUpdatingEntry<Object, DbContext>> FromUpdating(IScheduler scheduler) =>
			DbObservable<Object>.FromUpdating();

		IObservable<IUpdatingEntry<Object, DbContext>> IDbObservable.FromUpdating() =>
			DbObservable<Object>.FromUpdating();
		IObservable<IUpdatingEntry<Object, DbContext>> IDbObservable.FromUpdating(IScheduler scheduler) =>
			DbObservable<Object>.FromUpdating();

		public static IObservable<IUpdateFailedEntry<Object, DbContext>> FromUpdateFailed() =>
			DbObservable<Object>.FromUpdateFailed();
		public static IObservable<IUpdateFailedEntry<Object, DbContext>> FromUpdateFailed(IScheduler scheduler) =>
			DbObservable<Object>.FromUpdateFailed();

		IObservable<IUpdateFailedEntry<Object, DbContext>> IDbObservable.FromUpdateFailed() =>
			DbObservable<Object>.FromUpdateFailed();
		IObservable<IUpdateFailedEntry<Object, DbContext>> IDbObservable.FromUpdateFailed(IScheduler scheduler) =>
			DbObservable<Object>.FromUpdateFailed();

		public static IObservable<IUpdatedEntry<Object, DbContext>> FromUpdated() =>
			DbObservable<Object>.FromUpdated();
		public static IObservable<IUpdatedEntry<Object, DbContext>> FromUpdated(IScheduler scheduler) =>
			DbObservable<Object>.FromUpdated();

		IObservable<IUpdatedEntry<Object, DbContext>> IDbObservable.FromUpdated() =>
			DbObservable<Object>.FromUpdated();
		IObservable<IUpdatedEntry<Object, DbContext>> IDbObservable.FromUpdated(IScheduler scheduler) =>
			DbObservable<Object>.FromUpdated();

	}

	public sealed class DbObservable<TEntity>
	: IDbObservable<TEntity>
	where TEntity : class
	{
		private readonly ITriggers<TEntity, DbContext> triggers;
		public DbObservable(ITriggers<TEntity, DbContext> triggers) => this.triggers = triggers;

		public static IObservable<IInsertingEntry<TEntity, DbContext>> FromInserting() =>
			DbObservable<TEntity, DbContext>.FromInserting();
		public static IObservable<IInsertingEntry<TEntity, DbContext>> FromInserting(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromInserting();

		IObservable<IInsertingEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromInserting() =>
			DbObservable<TEntity, DbContext>.FromInserting();
		IObservable<IInsertingEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromInserting(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromInserting();

		public static IObservable<IInsertFailedEntry<TEntity, DbContext>> FromInsertFailed() =>
			DbObservable<TEntity, DbContext>.FromInsertFailed();
		public static IObservable<IInsertFailedEntry<TEntity, DbContext>> FromInsertFailed(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromInsertFailed();

		IObservable<IInsertFailedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromInsertFailed() =>
			DbObservable<TEntity, DbContext>.FromInsertFailed();
		IObservable<IInsertFailedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromInsertFailed(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromInsertFailed();

		public static IObservable<IInsertedEntry<TEntity, DbContext>> FromInserted() =>
			DbObservable<TEntity, DbContext>.FromInserted();
		public static IObservable<IInsertedEntry<TEntity, DbContext>> FromInserted(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromInserted();

		IObservable<IInsertedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromInserted() =>
			DbObservable<TEntity, DbContext>.FromInserted();
		IObservable<IInsertedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromInserted(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromInserted();

		public static IObservable<IDeletingEntry<TEntity, DbContext>> FromDeleting() =>
			DbObservable<TEntity, DbContext>.FromDeleting();
		public static IObservable<IDeletingEntry<TEntity, DbContext>> FromDeleting(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromDeleting();

		IObservable<IDeletingEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromDeleting() =>
			DbObservable<TEntity, DbContext>.FromDeleting();
		IObservable<IDeletingEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromDeleting(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromDeleting();

		public static IObservable<IDeleteFailedEntry<TEntity, DbContext>> FromDeleteFailed() =>
			DbObservable<TEntity, DbContext>.FromDeleteFailed();
		public static IObservable<IDeleteFailedEntry<TEntity, DbContext>> FromDeleteFailed(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromDeleteFailed();

		IObservable<IDeleteFailedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromDeleteFailed() =>
			DbObservable<TEntity, DbContext>.FromDeleteFailed();
		IObservable<IDeleteFailedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromDeleteFailed(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromDeleteFailed();

		public static IObservable<IDeletedEntry<TEntity, DbContext>> FromDeleted() =>
			DbObservable<TEntity, DbContext>.FromDeleted();
		public static IObservable<IDeletedEntry<TEntity, DbContext>> FromDeleted(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromDeleted();

		IObservable<IDeletedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromDeleted() =>
			DbObservable<TEntity, DbContext>.FromDeleted();
		IObservable<IDeletedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromDeleted(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromDeleted();

		public static IObservable<IUpdatingEntry<TEntity, DbContext>> FromUpdating() =>
			DbObservable<TEntity, DbContext>.FromUpdating();
		public static IObservable<IUpdatingEntry<TEntity, DbContext>> FromUpdating(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromUpdating();

		IObservable<IUpdatingEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromUpdating() =>
			DbObservable<TEntity, DbContext>.FromUpdating();
		IObservable<IUpdatingEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromUpdating(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromUpdating();

		public static IObservable<IUpdateFailedEntry<TEntity, DbContext>> FromUpdateFailed() =>
			DbObservable<TEntity, DbContext>.FromUpdateFailed();
		public static IObservable<IUpdateFailedEntry<TEntity, DbContext>> FromUpdateFailed(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromUpdateFailed();

		IObservable<IUpdateFailedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromUpdateFailed() =>
			DbObservable<TEntity, DbContext>.FromUpdateFailed();
		IObservable<IUpdateFailedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromUpdateFailed(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromUpdateFailed();

		public static IObservable<IUpdatedEntry<TEntity, DbContext>> FromUpdated() =>
			DbObservable<TEntity, DbContext>.FromUpdated();
		public static IObservable<IUpdatedEntry<TEntity, DbContext>> FromUpdated(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromUpdated();

		IObservable<IUpdatedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromUpdated() =>
			DbObservable<TEntity, DbContext>.FromUpdated();
		IObservable<IUpdatedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromUpdated(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromUpdated();

	}

	public sealed class DbObservable<TEntity, TDbContext>
	: IDbObservable<TEntity, TDbContext>
	where TEntity : class
	where TDbContext : DbContext
	{
		private readonly ITriggers<TEntity, TDbContext> triggers;
		public DbObservable(ITriggers<TEntity, TDbContext> triggers) => this.triggers = triggers;

		public static IObservable<IInsertingEntry<TEntity, TDbContext>> FromInserting() =>
			Observable.FromEvent<IInsertingEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalInserting.Add,
				Triggers<TEntity, TDbContext>.GlobalInserting.Remove
			);
		public static IObservable<IInsertingEntry<TEntity, TDbContext>> FromInserting(IScheduler scheduler) =>
			Observable.FromEvent<IInsertingEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalInserting.Add,
				Triggers<TEntity, TDbContext>.GlobalInserting.Remove,
				scheduler
			);
		public static IObservable<IInsertingEntry<TEntity, DbContext, TService>> FromInserting<TService>() =>
			Observable.FromEvent<IInsertingEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalInserting.Add,
				Triggers<TEntity, TDbContext>.GlobalInserting.Remove
			);
		public static IObservable<IInsertingEntry<TEntity, DbContext, TService>> FromInserting<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IInsertingEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalInserting.Add,
				Triggers<TEntity, TDbContext>.GlobalInserting.Remove,
				scheduler
			);

		IObservable<IInsertingEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromInserting() =>
			Observable.FromEvent<IInsertingEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalInserting.Add,
				Triggers<TEntity, TDbContext>.GlobalInserting.Remove
			);
		IObservable<IInsertingEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromInserting(IScheduler scheduler) =>
			Observable.FromEvent<IInsertingEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalInserting.Add,
				Triggers<TEntity, TDbContext>.GlobalInserting.Remove,
				scheduler
			);
		IObservable<IInsertingEntry<TEntity, DbContext, TService>> IDbObservable<TEntity, TDbContext>.FromInserting<TService>() =>
			Observable.FromEvent<IInsertingEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalInserting.Add,
				Triggers<TEntity, TDbContext>.GlobalInserting.Remove
			);
		IObservable<IInsertingEntry<TEntity, DbContext, TService>> IDbObservable<TEntity, TDbContext>.FromInserting<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IInsertingEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalInserting.Add,
				Triggers<TEntity, TDbContext>.GlobalInserting.Remove,
				scheduler
			);

		public static IObservable<IInsertFailedEntry<TEntity, TDbContext>> FromInsertFailed() =>
			Observable.FromEvent<IInsertFailedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalInsertFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalInsertFailed.Remove
			);
		public static IObservable<IInsertFailedEntry<TEntity, TDbContext>> FromInsertFailed(IScheduler scheduler) =>
			Observable.FromEvent<IInsertFailedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalInsertFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalInsertFailed.Remove,
				scheduler
			);
		public static IObservable<IInsertFailedEntry<TEntity, DbContext, TService>> FromInsertFailed<TService>() =>
			Observable.FromEvent<IInsertFailedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalInsertFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalInsertFailed.Remove
			);
		public static IObservable<IInsertFailedEntry<TEntity, DbContext, TService>> FromInsertFailed<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IInsertFailedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalInsertFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalInsertFailed.Remove,
				scheduler
			);

		IObservable<IInsertFailedEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromInsertFailed() =>
			Observable.FromEvent<IInsertFailedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalInsertFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalInsertFailed.Remove
			);
		IObservable<IInsertFailedEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromInsertFailed(IScheduler scheduler) =>
			Observable.FromEvent<IInsertFailedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalInsertFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalInsertFailed.Remove,
				scheduler
			);
		IObservable<IInsertFailedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity, TDbContext>.FromInsertFailed<TService>() =>
			Observable.FromEvent<IInsertFailedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalInsertFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalInsertFailed.Remove
			);
		IObservable<IInsertFailedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity, TDbContext>.FromInsertFailed<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IInsertFailedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalInsertFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalInsertFailed.Remove,
				scheduler
			);

		public static IObservable<IInsertedEntry<TEntity, TDbContext>> FromInserted() =>
			Observable.FromEvent<IInsertedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalInserted.Add,
				Triggers<TEntity, TDbContext>.GlobalInserted.Remove
			);
		public static IObservable<IInsertedEntry<TEntity, TDbContext>> FromInserted(IScheduler scheduler) =>
			Observable.FromEvent<IInsertedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalInserted.Add,
				Triggers<TEntity, TDbContext>.GlobalInserted.Remove,
				scheduler
			);
		public static IObservable<IInsertedEntry<TEntity, DbContext, TService>> FromInserted<TService>() =>
			Observable.FromEvent<IInsertedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalInserted.Add,
				Triggers<TEntity, TDbContext>.GlobalInserted.Remove
			);
		public static IObservable<IInsertedEntry<TEntity, DbContext, TService>> FromInserted<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IInsertedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalInserted.Add,
				Triggers<TEntity, TDbContext>.GlobalInserted.Remove,
				scheduler
			);

		IObservable<IInsertedEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromInserted() =>
			Observable.FromEvent<IInsertedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalInserted.Add,
				Triggers<TEntity, TDbContext>.GlobalInserted.Remove
			);
		IObservable<IInsertedEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromInserted(IScheduler scheduler) =>
			Observable.FromEvent<IInsertedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalInserted.Add,
				Triggers<TEntity, TDbContext>.GlobalInserted.Remove,
				scheduler
			);
		IObservable<IInsertedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity, TDbContext>.FromInserted<TService>() =>
			Observable.FromEvent<IInsertedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalInserted.Add,
				Triggers<TEntity, TDbContext>.GlobalInserted.Remove
			);
		IObservable<IInsertedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity, TDbContext>.FromInserted<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IInsertedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalInserted.Add,
				Triggers<TEntity, TDbContext>.GlobalInserted.Remove,
				scheduler
			);

		public static IObservable<IDeletingEntry<TEntity, TDbContext>> FromDeleting() =>
			Observable.FromEvent<IDeletingEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalDeleting.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleting.Remove
			);
		public static IObservable<IDeletingEntry<TEntity, TDbContext>> FromDeleting(IScheduler scheduler) =>
			Observable.FromEvent<IDeletingEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalDeleting.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleting.Remove,
				scheduler
			);
		public static IObservable<IDeletingEntry<TEntity, DbContext, TService>> FromDeleting<TService>() =>
			Observable.FromEvent<IDeletingEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalDeleting.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleting.Remove
			);
		public static IObservable<IDeletingEntry<TEntity, DbContext, TService>> FromDeleting<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IDeletingEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalDeleting.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleting.Remove,
				scheduler
			);

		IObservable<IDeletingEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromDeleting() =>
			Observable.FromEvent<IDeletingEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalDeleting.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleting.Remove
			);
		IObservable<IDeletingEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromDeleting(IScheduler scheduler) =>
			Observable.FromEvent<IDeletingEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalDeleting.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleting.Remove,
				scheduler
			);
		IObservable<IDeletingEntry<TEntity, DbContext, TService>> IDbObservable<TEntity, TDbContext>.FromDeleting<TService>() =>
			Observable.FromEvent<IDeletingEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalDeleting.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleting.Remove
			);
		IObservable<IDeletingEntry<TEntity, DbContext, TService>> IDbObservable<TEntity, TDbContext>.FromDeleting<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IDeletingEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalDeleting.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleting.Remove,
				scheduler
			);

		public static IObservable<IDeleteFailedEntry<TEntity, TDbContext>> FromDeleteFailed() =>
			Observable.FromEvent<IDeleteFailedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalDeleteFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleteFailed.Remove
			);
		public static IObservable<IDeleteFailedEntry<TEntity, TDbContext>> FromDeleteFailed(IScheduler scheduler) =>
			Observable.FromEvent<IDeleteFailedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalDeleteFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleteFailed.Remove,
				scheduler
			);
		public static IObservable<IDeleteFailedEntry<TEntity, DbContext, TService>> FromDeleteFailed<TService>() =>
			Observable.FromEvent<IDeleteFailedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalDeleteFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleteFailed.Remove
			);
		public static IObservable<IDeleteFailedEntry<TEntity, DbContext, TService>> FromDeleteFailed<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IDeleteFailedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalDeleteFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleteFailed.Remove,
				scheduler
			);

		IObservable<IDeleteFailedEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromDeleteFailed() =>
			Observable.FromEvent<IDeleteFailedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalDeleteFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleteFailed.Remove
			);
		IObservable<IDeleteFailedEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromDeleteFailed(IScheduler scheduler) =>
			Observable.FromEvent<IDeleteFailedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalDeleteFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleteFailed.Remove,
				scheduler
			);
		IObservable<IDeleteFailedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity, TDbContext>.FromDeleteFailed<TService>() =>
			Observable.FromEvent<IDeleteFailedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalDeleteFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleteFailed.Remove
			);
		IObservable<IDeleteFailedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity, TDbContext>.FromDeleteFailed<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IDeleteFailedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalDeleteFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleteFailed.Remove,
				scheduler
			);

		public static IObservable<IDeletedEntry<TEntity, TDbContext>> FromDeleted() =>
			Observable.FromEvent<IDeletedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalDeleted.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleted.Remove
			);
		public static IObservable<IDeletedEntry<TEntity, TDbContext>> FromDeleted(IScheduler scheduler) =>
			Observable.FromEvent<IDeletedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalDeleted.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleted.Remove,
				scheduler
			);
		public static IObservable<IDeletedEntry<TEntity, DbContext, TService>> FromDeleted<TService>() =>
			Observable.FromEvent<IDeletedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalDeleted.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleted.Remove
			);
		public static IObservable<IDeletedEntry<TEntity, DbContext, TService>> FromDeleted<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IDeletedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalDeleted.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleted.Remove,
				scheduler
			);

		IObservable<IDeletedEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromDeleted() =>
			Observable.FromEvent<IDeletedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalDeleted.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleted.Remove
			);
		IObservable<IDeletedEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromDeleted(IScheduler scheduler) =>
			Observable.FromEvent<IDeletedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalDeleted.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleted.Remove,
				scheduler
			);
		IObservable<IDeletedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity, TDbContext>.FromDeleted<TService>() =>
			Observable.FromEvent<IDeletedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalDeleted.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleted.Remove
			);
		IObservable<IDeletedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity, TDbContext>.FromDeleted<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IDeletedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalDeleted.Add,
				Triggers<TEntity, TDbContext>.GlobalDeleted.Remove,
				scheduler
			);

		public static IObservable<IUpdatingEntry<TEntity, TDbContext>> FromUpdating() =>
			Observable.FromEvent<IUpdatingEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalUpdating.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdating.Remove
			);
		public static IObservable<IUpdatingEntry<TEntity, TDbContext>> FromUpdating(IScheduler scheduler) =>
			Observable.FromEvent<IUpdatingEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalUpdating.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdating.Remove,
				scheduler
			);
		public static IObservable<IUpdatingEntry<TEntity, DbContext, TService>> FromUpdating<TService>() =>
			Observable.FromEvent<IUpdatingEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalUpdating.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdating.Remove
			);
		public static IObservable<IUpdatingEntry<TEntity, DbContext, TService>> FromUpdating<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IUpdatingEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalUpdating.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdating.Remove,
				scheduler
			);

		IObservable<IUpdatingEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromUpdating() =>
			Observable.FromEvent<IUpdatingEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalUpdating.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdating.Remove
			);
		IObservable<IUpdatingEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromUpdating(IScheduler scheduler) =>
			Observable.FromEvent<IUpdatingEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalUpdating.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdating.Remove,
				scheduler
			);
		IObservable<IUpdatingEntry<TEntity, DbContext, TService>> IDbObservable<TEntity, TDbContext>.FromUpdating<TService>() =>
			Observable.FromEvent<IUpdatingEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalUpdating.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdating.Remove
			);
		IObservable<IUpdatingEntry<TEntity, DbContext, TService>> IDbObservable<TEntity, TDbContext>.FromUpdating<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IUpdatingEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalUpdating.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdating.Remove,
				scheduler
			);

		public static IObservable<IUpdateFailedEntry<TEntity, TDbContext>> FromUpdateFailed() =>
			Observable.FromEvent<IUpdateFailedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalUpdateFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdateFailed.Remove
			);
		public static IObservable<IUpdateFailedEntry<TEntity, TDbContext>> FromUpdateFailed(IScheduler scheduler) =>
			Observable.FromEvent<IUpdateFailedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalUpdateFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdateFailed.Remove,
				scheduler
			);
		public static IObservable<IUpdateFailedEntry<TEntity, DbContext, TService>> FromUpdateFailed<TService>() =>
			Observable.FromEvent<IUpdateFailedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalUpdateFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdateFailed.Remove
			);
		public static IObservable<IUpdateFailedEntry<TEntity, DbContext, TService>> FromUpdateFailed<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IUpdateFailedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalUpdateFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdateFailed.Remove,
				scheduler
			);

		IObservable<IUpdateFailedEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromUpdateFailed() =>
			Observable.FromEvent<IUpdateFailedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalUpdateFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdateFailed.Remove
			);
		IObservable<IUpdateFailedEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromUpdateFailed(IScheduler scheduler) =>
			Observable.FromEvent<IUpdateFailedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalUpdateFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdateFailed.Remove,
				scheduler
			);
		IObservable<IUpdateFailedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity, TDbContext>.FromUpdateFailed<TService>() =>
			Observable.FromEvent<IUpdateFailedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalUpdateFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdateFailed.Remove
			);
		IObservable<IUpdateFailedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity, TDbContext>.FromUpdateFailed<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IUpdateFailedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalUpdateFailed.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdateFailed.Remove,
				scheduler
			);

		public static IObservable<IUpdatedEntry<TEntity, TDbContext>> FromUpdated() =>
			Observable.FromEvent<IUpdatedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalUpdated.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdated.Remove
			);
		public static IObservable<IUpdatedEntry<TEntity, TDbContext>> FromUpdated(IScheduler scheduler) =>
			Observable.FromEvent<IUpdatedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalUpdated.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdated.Remove,
				scheduler
			);
		public static IObservable<IUpdatedEntry<TEntity, DbContext, TService>> FromUpdated<TService>() =>
			Observable.FromEvent<IUpdatedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalUpdated.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdated.Remove
			);
		public static IObservable<IUpdatedEntry<TEntity, DbContext, TService>> FromUpdated<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IUpdatedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalUpdated.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdated.Remove,
				scheduler
			);

		IObservable<IUpdatedEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromUpdated() =>
			Observable.FromEvent<IUpdatedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalUpdated.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdated.Remove
			);
		IObservable<IUpdatedEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromUpdated(IScheduler scheduler) =>
			Observable.FromEvent<IUpdatedEntry<TEntity, TDbContext>>(
				Triggers<TEntity, TDbContext>.GlobalUpdated.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdated.Remove,
				scheduler
			);
		IObservable<IUpdatedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity, TDbContext>.FromUpdated<TService>() =>
			Observable.FromEvent<IUpdatedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalUpdated.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdated.Remove
			);
		IObservable<IUpdatedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity, TDbContext>.FromUpdated<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IUpdatedEntry<TEntity, DbContext, TService>>(
				Triggers<TEntity, TDbContext>.GlobalUpdated.Add,
				Triggers<TEntity, TDbContext>.GlobalUpdated.Remove,
				scheduler
			);

	}
}