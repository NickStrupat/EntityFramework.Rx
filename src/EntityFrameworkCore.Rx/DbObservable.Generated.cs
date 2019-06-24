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
		private readonly IDbObservable<Object, DbContext> dbObservable;
		public DbObservable(IDbObservable<Object, DbContext> dbObservable) => this.dbObservable = dbObservable;

		public static IObservable<IInsertingEntry<Object, DbContext>> FromInserting() =>
			DbObservable<Object, DbContext>.FromInserting();
		public static IObservable<IInsertingEntry<Object, DbContext>> FromInserting(IScheduler scheduler) =>
			DbObservable<Object, DbContext>.FromInserting();
		public static IObservable<IInsertingEntry<Object, DbContext, TService>> FromInserting<TService>() =>
			DbObservable<Object, DbContext>.FromInserting<TService>();
		public static IObservable<IInsertingEntry<Object, DbContext, TService>> FromInserting<TService>(IScheduler scheduler) =>
			DbObservable<Object, DbContext>.FromInserting<TService>();

		IObservable<IInsertingEntry<Object, DbContext>> IDbObservable.FromInserting() =>
			dbObservable.FromInserting();
		IObservable<IInsertingEntry<Object, DbContext>> IDbObservable.FromInserting(IScheduler scheduler) =>
			dbObservable.FromInserting();
		IObservable<IInsertingEntry<Object, DbContext, TService>> IDbObservable.FromInserting<TService>() =>
			dbObservable.FromInserting<TService>();
		IObservable<IInsertingEntry<Object, DbContext, TService>> IDbObservable.FromInserting<TService>(IScheduler scheduler) =>
			dbObservable.FromInserting<TService>();

		public static IObservable<IInsertFailedEntry<Object, DbContext>> FromInsertFailed() =>
			DbObservable<Object, DbContext>.FromInsertFailed();
		public static IObservable<IInsertFailedEntry<Object, DbContext>> FromInsertFailed(IScheduler scheduler) =>
			DbObservable<Object, DbContext>.FromInsertFailed();
		public static IObservable<IInsertFailedEntry<Object, DbContext, TService>> FromInsertFailed<TService>() =>
			DbObservable<Object, DbContext>.FromInsertFailed<TService>();
		public static IObservable<IInsertFailedEntry<Object, DbContext, TService>> FromInsertFailed<TService>(IScheduler scheduler) =>
			DbObservable<Object, DbContext>.FromInsertFailed<TService>();

		IObservable<IInsertFailedEntry<Object, DbContext>> IDbObservable.FromInsertFailed() =>
			dbObservable.FromInsertFailed();
		IObservable<IInsertFailedEntry<Object, DbContext>> IDbObservable.FromInsertFailed(IScheduler scheduler) =>
			dbObservable.FromInsertFailed();
		IObservable<IInsertFailedEntry<Object, DbContext, TService>> IDbObservable.FromInsertFailed<TService>() =>
			dbObservable.FromInsertFailed<TService>();
		IObservable<IInsertFailedEntry<Object, DbContext, TService>> IDbObservable.FromInsertFailed<TService>(IScheduler scheduler) =>
			dbObservable.FromInsertFailed<TService>();

		public static IObservable<IInsertedEntry<Object, DbContext>> FromInserted() =>
			DbObservable<Object, DbContext>.FromInserted();
		public static IObservable<IInsertedEntry<Object, DbContext>> FromInserted(IScheduler scheduler) =>
			DbObservable<Object, DbContext>.FromInserted();
		public static IObservable<IInsertedEntry<Object, DbContext, TService>> FromInserted<TService>() =>
			DbObservable<Object, DbContext>.FromInserted<TService>();
		public static IObservable<IInsertedEntry<Object, DbContext, TService>> FromInserted<TService>(IScheduler scheduler) =>
			DbObservable<Object, DbContext>.FromInserted<TService>();

		IObservable<IInsertedEntry<Object, DbContext>> IDbObservable.FromInserted() =>
			dbObservable.FromInserted();
		IObservable<IInsertedEntry<Object, DbContext>> IDbObservable.FromInserted(IScheduler scheduler) =>
			dbObservable.FromInserted();
		IObservable<IInsertedEntry<Object, DbContext, TService>> IDbObservable.FromInserted<TService>() =>
			dbObservable.FromInserted<TService>();
		IObservable<IInsertedEntry<Object, DbContext, TService>> IDbObservable.FromInserted<TService>(IScheduler scheduler) =>
			dbObservable.FromInserted<TService>();

		public static IObservable<IDeletingEntry<Object, DbContext>> FromDeleting() =>
			DbObservable<Object, DbContext>.FromDeleting();
		public static IObservable<IDeletingEntry<Object, DbContext>> FromDeleting(IScheduler scheduler) =>
			DbObservable<Object, DbContext>.FromDeleting();
		public static IObservable<IDeletingEntry<Object, DbContext, TService>> FromDeleting<TService>() =>
			DbObservable<Object, DbContext>.FromDeleting<TService>();
		public static IObservable<IDeletingEntry<Object, DbContext, TService>> FromDeleting<TService>(IScheduler scheduler) =>
			DbObservable<Object, DbContext>.FromDeleting<TService>();

		IObservable<IDeletingEntry<Object, DbContext>> IDbObservable.FromDeleting() =>
			dbObservable.FromDeleting();
		IObservable<IDeletingEntry<Object, DbContext>> IDbObservable.FromDeleting(IScheduler scheduler) =>
			dbObservable.FromDeleting();
		IObservable<IDeletingEntry<Object, DbContext, TService>> IDbObservable.FromDeleting<TService>() =>
			dbObservable.FromDeleting<TService>();
		IObservable<IDeletingEntry<Object, DbContext, TService>> IDbObservable.FromDeleting<TService>(IScheduler scheduler) =>
			dbObservable.FromDeleting<TService>();

		public static IObservable<IDeleteFailedEntry<Object, DbContext>> FromDeleteFailed() =>
			DbObservable<Object, DbContext>.FromDeleteFailed();
		public static IObservable<IDeleteFailedEntry<Object, DbContext>> FromDeleteFailed(IScheduler scheduler) =>
			DbObservable<Object, DbContext>.FromDeleteFailed();
		public static IObservable<IDeleteFailedEntry<Object, DbContext, TService>> FromDeleteFailed<TService>() =>
			DbObservable<Object, DbContext>.FromDeleteFailed<TService>();
		public static IObservable<IDeleteFailedEntry<Object, DbContext, TService>> FromDeleteFailed<TService>(IScheduler scheduler) =>
			DbObservable<Object, DbContext>.FromDeleteFailed<TService>();

		IObservable<IDeleteFailedEntry<Object, DbContext>> IDbObservable.FromDeleteFailed() =>
			dbObservable.FromDeleteFailed();
		IObservable<IDeleteFailedEntry<Object, DbContext>> IDbObservable.FromDeleteFailed(IScheduler scheduler) =>
			dbObservable.FromDeleteFailed();
		IObservable<IDeleteFailedEntry<Object, DbContext, TService>> IDbObservable.FromDeleteFailed<TService>() =>
			dbObservable.FromDeleteFailed<TService>();
		IObservable<IDeleteFailedEntry<Object, DbContext, TService>> IDbObservable.FromDeleteFailed<TService>(IScheduler scheduler) =>
			dbObservable.FromDeleteFailed<TService>();

		public static IObservable<IDeletedEntry<Object, DbContext>> FromDeleted() =>
			DbObservable<Object, DbContext>.FromDeleted();
		public static IObservable<IDeletedEntry<Object, DbContext>> FromDeleted(IScheduler scheduler) =>
			DbObservable<Object, DbContext>.FromDeleted();
		public static IObservable<IDeletedEntry<Object, DbContext, TService>> FromDeleted<TService>() =>
			DbObservable<Object, DbContext>.FromDeleted<TService>();
		public static IObservable<IDeletedEntry<Object, DbContext, TService>> FromDeleted<TService>(IScheduler scheduler) =>
			DbObservable<Object, DbContext>.FromDeleted<TService>();

		IObservable<IDeletedEntry<Object, DbContext>> IDbObservable.FromDeleted() =>
			dbObservable.FromDeleted();
		IObservable<IDeletedEntry<Object, DbContext>> IDbObservable.FromDeleted(IScheduler scheduler) =>
			dbObservable.FromDeleted();
		IObservable<IDeletedEntry<Object, DbContext, TService>> IDbObservable.FromDeleted<TService>() =>
			dbObservable.FromDeleted<TService>();
		IObservable<IDeletedEntry<Object, DbContext, TService>> IDbObservable.FromDeleted<TService>(IScheduler scheduler) =>
			dbObservable.FromDeleted<TService>();

		public static IObservable<IUpdatingEntry<Object, DbContext>> FromUpdating() =>
			DbObservable<Object, DbContext>.FromUpdating();
		public static IObservable<IUpdatingEntry<Object, DbContext>> FromUpdating(IScheduler scheduler) =>
			DbObservable<Object, DbContext>.FromUpdating();
		public static IObservable<IUpdatingEntry<Object, DbContext, TService>> FromUpdating<TService>() =>
			DbObservable<Object, DbContext>.FromUpdating<TService>();
		public static IObservable<IUpdatingEntry<Object, DbContext, TService>> FromUpdating<TService>(IScheduler scheduler) =>
			DbObservable<Object, DbContext>.FromUpdating<TService>();

		IObservable<IUpdatingEntry<Object, DbContext>> IDbObservable.FromUpdating() =>
			dbObservable.FromUpdating();
		IObservable<IUpdatingEntry<Object, DbContext>> IDbObservable.FromUpdating(IScheduler scheduler) =>
			dbObservable.FromUpdating();
		IObservable<IUpdatingEntry<Object, DbContext, TService>> IDbObservable.FromUpdating<TService>() =>
			dbObservable.FromUpdating<TService>();
		IObservable<IUpdatingEntry<Object, DbContext, TService>> IDbObservable.FromUpdating<TService>(IScheduler scheduler) =>
			dbObservable.FromUpdating<TService>();

		public static IObservable<IUpdateFailedEntry<Object, DbContext>> FromUpdateFailed() =>
			DbObservable<Object, DbContext>.FromUpdateFailed();
		public static IObservable<IUpdateFailedEntry<Object, DbContext>> FromUpdateFailed(IScheduler scheduler) =>
			DbObservable<Object, DbContext>.FromUpdateFailed();
		public static IObservable<IUpdateFailedEntry<Object, DbContext, TService>> FromUpdateFailed<TService>() =>
			DbObservable<Object, DbContext>.FromUpdateFailed<TService>();
		public static IObservable<IUpdateFailedEntry<Object, DbContext, TService>> FromUpdateFailed<TService>(IScheduler scheduler) =>
			DbObservable<Object, DbContext>.FromUpdateFailed<TService>();

		IObservable<IUpdateFailedEntry<Object, DbContext>> IDbObservable.FromUpdateFailed() =>
			dbObservable.FromUpdateFailed();
		IObservable<IUpdateFailedEntry<Object, DbContext>> IDbObservable.FromUpdateFailed(IScheduler scheduler) =>
			dbObservable.FromUpdateFailed();
		IObservable<IUpdateFailedEntry<Object, DbContext, TService>> IDbObservable.FromUpdateFailed<TService>() =>
			dbObservable.FromUpdateFailed<TService>();
		IObservable<IUpdateFailedEntry<Object, DbContext, TService>> IDbObservable.FromUpdateFailed<TService>(IScheduler scheduler) =>
			dbObservable.FromUpdateFailed<TService>();

		public static IObservable<IUpdatedEntry<Object, DbContext>> FromUpdated() =>
			DbObservable<Object, DbContext>.FromUpdated();
		public static IObservable<IUpdatedEntry<Object, DbContext>> FromUpdated(IScheduler scheduler) =>
			DbObservable<Object, DbContext>.FromUpdated();
		public static IObservable<IUpdatedEntry<Object, DbContext, TService>> FromUpdated<TService>() =>
			DbObservable<Object, DbContext>.FromUpdated<TService>();
		public static IObservable<IUpdatedEntry<Object, DbContext, TService>> FromUpdated<TService>(IScheduler scheduler) =>
			DbObservable<Object, DbContext>.FromUpdated<TService>();

		IObservable<IUpdatedEntry<Object, DbContext>> IDbObservable.FromUpdated() =>
			dbObservable.FromUpdated();
		IObservable<IUpdatedEntry<Object, DbContext>> IDbObservable.FromUpdated(IScheduler scheduler) =>
			dbObservable.FromUpdated();
		IObservable<IUpdatedEntry<Object, DbContext, TService>> IDbObservable.FromUpdated<TService>() =>
			dbObservable.FromUpdated<TService>();
		IObservable<IUpdatedEntry<Object, DbContext, TService>> IDbObservable.FromUpdated<TService>(IScheduler scheduler) =>
			dbObservable.FromUpdated<TService>();

	}

	public sealed class DbObservable<TEntity>
	: IDbObservable<TEntity>
	where TEntity : class
	{
		private readonly IDbObservable<TEntity, DbContext> dbObservable;
		public DbObservable(IDbObservable<TEntity, DbContext> dbObservable) => this.dbObservable = dbObservable;

		public static IObservable<IInsertingEntry<TEntity, DbContext>> FromInserting() =>
			DbObservable<TEntity, DbContext>.FromInserting();
		public static IObservable<IInsertingEntry<TEntity, DbContext>> FromInserting(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromInserting();
		public static IObservable<IInsertingEntry<TEntity, DbContext, TService>> FromInserting<TService>() =>
			DbObservable<TEntity, DbContext>.FromInserting<TService>();
		public static IObservable<IInsertingEntry<TEntity, DbContext, TService>> FromInserting<TService>(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromInserting<TService>();

		IObservable<IInsertingEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromInserting() =>
			dbObservable.FromInserting();
		IObservable<IInsertingEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromInserting(IScheduler scheduler) =>
			dbObservable.FromInserting();
		IObservable<IInsertingEntry<TEntity, DbContext, TService>> IDbObservable<TEntity>.FromInserting<TService>() =>
			dbObservable.FromInserting<TService>();
		IObservable<IInsertingEntry<TEntity, DbContext, TService>> IDbObservable<TEntity>.FromInserting<TService>(IScheduler scheduler) =>
			dbObservable.FromInserting<TService>();

		public static IObservable<IInsertFailedEntry<TEntity, DbContext>> FromInsertFailed() =>
			DbObservable<TEntity, DbContext>.FromInsertFailed();
		public static IObservable<IInsertFailedEntry<TEntity, DbContext>> FromInsertFailed(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromInsertFailed();
		public static IObservable<IInsertFailedEntry<TEntity, DbContext, TService>> FromInsertFailed<TService>() =>
			DbObservable<TEntity, DbContext>.FromInsertFailed<TService>();
		public static IObservable<IInsertFailedEntry<TEntity, DbContext, TService>> FromInsertFailed<TService>(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromInsertFailed<TService>();

		IObservable<IInsertFailedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromInsertFailed() =>
			dbObservable.FromInsertFailed();
		IObservable<IInsertFailedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromInsertFailed(IScheduler scheduler) =>
			dbObservable.FromInsertFailed();
		IObservable<IInsertFailedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity>.FromInsertFailed<TService>() =>
			dbObservable.FromInsertFailed<TService>();
		IObservable<IInsertFailedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity>.FromInsertFailed<TService>(IScheduler scheduler) =>
			dbObservable.FromInsertFailed<TService>();

		public static IObservable<IInsertedEntry<TEntity, DbContext>> FromInserted() =>
			DbObservable<TEntity, DbContext>.FromInserted();
		public static IObservable<IInsertedEntry<TEntity, DbContext>> FromInserted(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromInserted();
		public static IObservable<IInsertedEntry<TEntity, DbContext, TService>> FromInserted<TService>() =>
			DbObservable<TEntity, DbContext>.FromInserted<TService>();
		public static IObservable<IInsertedEntry<TEntity, DbContext, TService>> FromInserted<TService>(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromInserted<TService>();

		IObservable<IInsertedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromInserted() =>
			dbObservable.FromInserted();
		IObservable<IInsertedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromInserted(IScheduler scheduler) =>
			dbObservable.FromInserted();
		IObservable<IInsertedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity>.FromInserted<TService>() =>
			dbObservable.FromInserted<TService>();
		IObservable<IInsertedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity>.FromInserted<TService>(IScheduler scheduler) =>
			dbObservable.FromInserted<TService>();

		public static IObservable<IDeletingEntry<TEntity, DbContext>> FromDeleting() =>
			DbObservable<TEntity, DbContext>.FromDeleting();
		public static IObservable<IDeletingEntry<TEntity, DbContext>> FromDeleting(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromDeleting();
		public static IObservable<IDeletingEntry<TEntity, DbContext, TService>> FromDeleting<TService>() =>
			DbObservable<TEntity, DbContext>.FromDeleting<TService>();
		public static IObservable<IDeletingEntry<TEntity, DbContext, TService>> FromDeleting<TService>(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromDeleting<TService>();

		IObservable<IDeletingEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromDeleting() =>
			dbObservable.FromDeleting();
		IObservable<IDeletingEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromDeleting(IScheduler scheduler) =>
			dbObservable.FromDeleting();
		IObservable<IDeletingEntry<TEntity, DbContext, TService>> IDbObservable<TEntity>.FromDeleting<TService>() =>
			dbObservable.FromDeleting<TService>();
		IObservable<IDeletingEntry<TEntity, DbContext, TService>> IDbObservable<TEntity>.FromDeleting<TService>(IScheduler scheduler) =>
			dbObservable.FromDeleting<TService>();

		public static IObservable<IDeleteFailedEntry<TEntity, DbContext>> FromDeleteFailed() =>
			DbObservable<TEntity, DbContext>.FromDeleteFailed();
		public static IObservable<IDeleteFailedEntry<TEntity, DbContext>> FromDeleteFailed(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromDeleteFailed();
		public static IObservable<IDeleteFailedEntry<TEntity, DbContext, TService>> FromDeleteFailed<TService>() =>
			DbObservable<TEntity, DbContext>.FromDeleteFailed<TService>();
		public static IObservable<IDeleteFailedEntry<TEntity, DbContext, TService>> FromDeleteFailed<TService>(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromDeleteFailed<TService>();

		IObservable<IDeleteFailedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromDeleteFailed() =>
			dbObservable.FromDeleteFailed();
		IObservable<IDeleteFailedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromDeleteFailed(IScheduler scheduler) =>
			dbObservable.FromDeleteFailed();
		IObservable<IDeleteFailedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity>.FromDeleteFailed<TService>() =>
			dbObservable.FromDeleteFailed<TService>();
		IObservable<IDeleteFailedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity>.FromDeleteFailed<TService>(IScheduler scheduler) =>
			dbObservable.FromDeleteFailed<TService>();

		public static IObservable<IDeletedEntry<TEntity, DbContext>> FromDeleted() =>
			DbObservable<TEntity, DbContext>.FromDeleted();
		public static IObservable<IDeletedEntry<TEntity, DbContext>> FromDeleted(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromDeleted();
		public static IObservable<IDeletedEntry<TEntity, DbContext, TService>> FromDeleted<TService>() =>
			DbObservable<TEntity, DbContext>.FromDeleted<TService>();
		public static IObservable<IDeletedEntry<TEntity, DbContext, TService>> FromDeleted<TService>(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromDeleted<TService>();

		IObservable<IDeletedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromDeleted() =>
			dbObservable.FromDeleted();
		IObservable<IDeletedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromDeleted(IScheduler scheduler) =>
			dbObservable.FromDeleted();
		IObservable<IDeletedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity>.FromDeleted<TService>() =>
			dbObservable.FromDeleted<TService>();
		IObservable<IDeletedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity>.FromDeleted<TService>(IScheduler scheduler) =>
			dbObservable.FromDeleted<TService>();

		public static IObservable<IUpdatingEntry<TEntity, DbContext>> FromUpdating() =>
			DbObservable<TEntity, DbContext>.FromUpdating();
		public static IObservable<IUpdatingEntry<TEntity, DbContext>> FromUpdating(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromUpdating();
		public static IObservable<IUpdatingEntry<TEntity, DbContext, TService>> FromUpdating<TService>() =>
			DbObservable<TEntity, DbContext>.FromUpdating<TService>();
		public static IObservable<IUpdatingEntry<TEntity, DbContext, TService>> FromUpdating<TService>(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromUpdating<TService>();

		IObservable<IUpdatingEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromUpdating() =>
			dbObservable.FromUpdating();
		IObservable<IUpdatingEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromUpdating(IScheduler scheduler) =>
			dbObservable.FromUpdating();
		IObservable<IUpdatingEntry<TEntity, DbContext, TService>> IDbObservable<TEntity>.FromUpdating<TService>() =>
			dbObservable.FromUpdating<TService>();
		IObservable<IUpdatingEntry<TEntity, DbContext, TService>> IDbObservable<TEntity>.FromUpdating<TService>(IScheduler scheduler) =>
			dbObservable.FromUpdating<TService>();

		public static IObservable<IUpdateFailedEntry<TEntity, DbContext>> FromUpdateFailed() =>
			DbObservable<TEntity, DbContext>.FromUpdateFailed();
		public static IObservable<IUpdateFailedEntry<TEntity, DbContext>> FromUpdateFailed(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromUpdateFailed();
		public static IObservable<IUpdateFailedEntry<TEntity, DbContext, TService>> FromUpdateFailed<TService>() =>
			DbObservable<TEntity, DbContext>.FromUpdateFailed<TService>();
		public static IObservable<IUpdateFailedEntry<TEntity, DbContext, TService>> FromUpdateFailed<TService>(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromUpdateFailed<TService>();

		IObservable<IUpdateFailedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromUpdateFailed() =>
			dbObservable.FromUpdateFailed();
		IObservable<IUpdateFailedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromUpdateFailed(IScheduler scheduler) =>
			dbObservable.FromUpdateFailed();
		IObservable<IUpdateFailedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity>.FromUpdateFailed<TService>() =>
			dbObservable.FromUpdateFailed<TService>();
		IObservable<IUpdateFailedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity>.FromUpdateFailed<TService>(IScheduler scheduler) =>
			dbObservable.FromUpdateFailed<TService>();

		public static IObservable<IUpdatedEntry<TEntity, DbContext>> FromUpdated() =>
			DbObservable<TEntity, DbContext>.FromUpdated();
		public static IObservable<IUpdatedEntry<TEntity, DbContext>> FromUpdated(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromUpdated();
		public static IObservable<IUpdatedEntry<TEntity, DbContext, TService>> FromUpdated<TService>() =>
			DbObservable<TEntity, DbContext>.FromUpdated<TService>();
		public static IObservable<IUpdatedEntry<TEntity, DbContext, TService>> FromUpdated<TService>(IScheduler scheduler) =>
			DbObservable<TEntity, DbContext>.FromUpdated<TService>();

		IObservable<IUpdatedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromUpdated() =>
			dbObservable.FromUpdated();
		IObservable<IUpdatedEntry<TEntity, DbContext>> IDbObservable<TEntity>.FromUpdated(IScheduler scheduler) =>
			dbObservable.FromUpdated();
		IObservable<IUpdatedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity>.FromUpdated<TService>() =>
			dbObservable.FromUpdated<TService>();
		IObservable<IUpdatedEntry<TEntity, DbContext, TService>> IDbObservable<TEntity>.FromUpdated<TService>(IScheduler scheduler) =>
			dbObservable.FromUpdated<TService>();

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
				triggers.Inserting.Add,
				triggers.Inserting.Remove
			);
		IObservable<IInsertingEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromInserting(IScheduler scheduler) =>
			Observable.FromEvent<IInsertingEntry<TEntity, TDbContext>>(
				triggers.Inserting.Add,
				triggers.Inserting.Remove,
				scheduler
			);
		IObservable<IInsertingEntry<TEntity, TDbContext, TService>> IDbObservable<TEntity, TDbContext>.FromInserting<TService>() =>
			Observable.FromEvent<IInsertingEntry<TEntity, TDbContext, TService>>(
				triggers.Inserting.Add,
				triggers.Inserting.Remove
			);
		IObservable<IInsertingEntry<TEntity, TDbContext, TService>> IDbObservable<TEntity, TDbContext>.FromInserting<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IInsertingEntry<TEntity, TDbContext, TService>>(
				triggers.Inserting.Add,
				triggers.Inserting.Remove,
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
				triggers.InsertFailed.Add,
				triggers.InsertFailed.Remove
			);
		IObservable<IInsertFailedEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromInsertFailed(IScheduler scheduler) =>
			Observable.FromEvent<IInsertFailedEntry<TEntity, TDbContext>>(
				triggers.InsertFailed.Add,
				triggers.InsertFailed.Remove,
				scheduler
			);
		IObservable<IInsertFailedEntry<TEntity, TDbContext, TService>> IDbObservable<TEntity, TDbContext>.FromInsertFailed<TService>() =>
			Observable.FromEvent<IInsertFailedEntry<TEntity, TDbContext, TService>>(
				triggers.InsertFailed.Add,
				triggers.InsertFailed.Remove
			);
		IObservable<IInsertFailedEntry<TEntity, TDbContext, TService>> IDbObservable<TEntity, TDbContext>.FromInsertFailed<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IInsertFailedEntry<TEntity, TDbContext, TService>>(
				triggers.InsertFailed.Add,
				triggers.InsertFailed.Remove,
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
				triggers.Inserted.Add,
				triggers.Inserted.Remove
			);
		IObservable<IInsertedEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromInserted(IScheduler scheduler) =>
			Observable.FromEvent<IInsertedEntry<TEntity, TDbContext>>(
				triggers.Inserted.Add,
				triggers.Inserted.Remove,
				scheduler
			);
		IObservable<IInsertedEntry<TEntity, TDbContext, TService>> IDbObservable<TEntity, TDbContext>.FromInserted<TService>() =>
			Observable.FromEvent<IInsertedEntry<TEntity, TDbContext, TService>>(
				triggers.Inserted.Add,
				triggers.Inserted.Remove
			);
		IObservable<IInsertedEntry<TEntity, TDbContext, TService>> IDbObservable<TEntity, TDbContext>.FromInserted<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IInsertedEntry<TEntity, TDbContext, TService>>(
				triggers.Inserted.Add,
				triggers.Inserted.Remove,
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
				triggers.Deleting.Add,
				triggers.Deleting.Remove
			);
		IObservable<IDeletingEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromDeleting(IScheduler scheduler) =>
			Observable.FromEvent<IDeletingEntry<TEntity, TDbContext>>(
				triggers.Deleting.Add,
				triggers.Deleting.Remove,
				scheduler
			);
		IObservable<IDeletingEntry<TEntity, TDbContext, TService>> IDbObservable<TEntity, TDbContext>.FromDeleting<TService>() =>
			Observable.FromEvent<IDeletingEntry<TEntity, TDbContext, TService>>(
				triggers.Deleting.Add,
				triggers.Deleting.Remove
			);
		IObservable<IDeletingEntry<TEntity, TDbContext, TService>> IDbObservable<TEntity, TDbContext>.FromDeleting<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IDeletingEntry<TEntity, TDbContext, TService>>(
				triggers.Deleting.Add,
				triggers.Deleting.Remove,
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
				triggers.DeleteFailed.Add,
				triggers.DeleteFailed.Remove
			);
		IObservable<IDeleteFailedEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromDeleteFailed(IScheduler scheduler) =>
			Observable.FromEvent<IDeleteFailedEntry<TEntity, TDbContext>>(
				triggers.DeleteFailed.Add,
				triggers.DeleteFailed.Remove,
				scheduler
			);
		IObservable<IDeleteFailedEntry<TEntity, TDbContext, TService>> IDbObservable<TEntity, TDbContext>.FromDeleteFailed<TService>() =>
			Observable.FromEvent<IDeleteFailedEntry<TEntity, TDbContext, TService>>(
				triggers.DeleteFailed.Add,
				triggers.DeleteFailed.Remove
			);
		IObservable<IDeleteFailedEntry<TEntity, TDbContext, TService>> IDbObservable<TEntity, TDbContext>.FromDeleteFailed<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IDeleteFailedEntry<TEntity, TDbContext, TService>>(
				triggers.DeleteFailed.Add,
				triggers.DeleteFailed.Remove,
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
				triggers.Deleted.Add,
				triggers.Deleted.Remove
			);
		IObservable<IDeletedEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromDeleted(IScheduler scheduler) =>
			Observable.FromEvent<IDeletedEntry<TEntity, TDbContext>>(
				triggers.Deleted.Add,
				triggers.Deleted.Remove,
				scheduler
			);
		IObservable<IDeletedEntry<TEntity, TDbContext, TService>> IDbObservable<TEntity, TDbContext>.FromDeleted<TService>() =>
			Observable.FromEvent<IDeletedEntry<TEntity, TDbContext, TService>>(
				triggers.Deleted.Add,
				triggers.Deleted.Remove
			);
		IObservable<IDeletedEntry<TEntity, TDbContext, TService>> IDbObservable<TEntity, TDbContext>.FromDeleted<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IDeletedEntry<TEntity, TDbContext, TService>>(
				triggers.Deleted.Add,
				triggers.Deleted.Remove,
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
				triggers.Updating.Add,
				triggers.Updating.Remove
			);
		IObservable<IUpdatingEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromUpdating(IScheduler scheduler) =>
			Observable.FromEvent<IUpdatingEntry<TEntity, TDbContext>>(
				triggers.Updating.Add,
				triggers.Updating.Remove,
				scheduler
			);
		IObservable<IUpdatingEntry<TEntity, TDbContext, TService>> IDbObservable<TEntity, TDbContext>.FromUpdating<TService>() =>
			Observable.FromEvent<IUpdatingEntry<TEntity, TDbContext, TService>>(
				triggers.Updating.Add,
				triggers.Updating.Remove
			);
		IObservable<IUpdatingEntry<TEntity, TDbContext, TService>> IDbObservable<TEntity, TDbContext>.FromUpdating<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IUpdatingEntry<TEntity, TDbContext, TService>>(
				triggers.Updating.Add,
				triggers.Updating.Remove,
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
				triggers.UpdateFailed.Add,
				triggers.UpdateFailed.Remove
			);
		IObservable<IUpdateFailedEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromUpdateFailed(IScheduler scheduler) =>
			Observable.FromEvent<IUpdateFailedEntry<TEntity, TDbContext>>(
				triggers.UpdateFailed.Add,
				triggers.UpdateFailed.Remove,
				scheduler
			);
		IObservable<IUpdateFailedEntry<TEntity, TDbContext, TService>> IDbObservable<TEntity, TDbContext>.FromUpdateFailed<TService>() =>
			Observable.FromEvent<IUpdateFailedEntry<TEntity, TDbContext, TService>>(
				triggers.UpdateFailed.Add,
				triggers.UpdateFailed.Remove
			);
		IObservable<IUpdateFailedEntry<TEntity, TDbContext, TService>> IDbObservable<TEntity, TDbContext>.FromUpdateFailed<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IUpdateFailedEntry<TEntity, TDbContext, TService>>(
				triggers.UpdateFailed.Add,
				triggers.UpdateFailed.Remove,
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
				triggers.Updated.Add,
				triggers.Updated.Remove
			);
		IObservable<IUpdatedEntry<TEntity, TDbContext>> IDbObservable<TEntity, TDbContext>.FromUpdated(IScheduler scheduler) =>
			Observable.FromEvent<IUpdatedEntry<TEntity, TDbContext>>(
				triggers.Updated.Add,
				triggers.Updated.Remove,
				scheduler
			);
		IObservable<IUpdatedEntry<TEntity, TDbContext, TService>> IDbObservable<TEntity, TDbContext>.FromUpdated<TService>() =>
			Observable.FromEvent<IUpdatedEntry<TEntity, TDbContext, TService>>(
				triggers.Updated.Add,
				triggers.Updated.Remove
			);
		IObservable<IUpdatedEntry<TEntity, TDbContext, TService>> IDbObservable<TEntity, TDbContext>.FromUpdated<TService>(IScheduler scheduler) =>
			Observable.FromEvent<IUpdatedEntry<TEntity, TDbContext, TService>>(
				triggers.Updated.Add,
				triggers.Updated.Remove,
				scheduler
			);

	}
}