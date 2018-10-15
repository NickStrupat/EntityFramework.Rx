using System;
using System.Reactive.Concurrency;

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
	public interface IDbObservable
	{

		IObservable<IInsertingEntry   <Object, DbContext>> FromInserting();
		IObservable<IInsertingEntry   <Object, DbContext>> FromInserting(IScheduler scheduler);

		IObservable<IInsertFailedEntry<Object, DbContext>> FromInsertFailed();
		IObservable<IInsertFailedEntry<Object, DbContext>> FromInsertFailed(IScheduler scheduler);

		IObservable<IInsertedEntry    <Object, DbContext>> FromInserted();
		IObservable<IInsertedEntry    <Object, DbContext>> FromInserted(IScheduler scheduler);

		IObservable<IDeletingEntry    <Object, DbContext>> FromDeleting();
		IObservable<IDeletingEntry    <Object, DbContext>> FromDeleting(IScheduler scheduler);

		IObservable<IDeleteFailedEntry<Object, DbContext>> FromDeleteFailed();
		IObservable<IDeleteFailedEntry<Object, DbContext>> FromDeleteFailed(IScheduler scheduler);

		IObservable<IDeletedEntry     <Object, DbContext>> FromDeleted();
		IObservable<IDeletedEntry     <Object, DbContext>> FromDeleted(IScheduler scheduler);

		IObservable<IUpdatingEntry    <Object, DbContext>> FromUpdating();
		IObservable<IUpdatingEntry    <Object, DbContext>> FromUpdating(IScheduler scheduler);

		IObservable<IUpdateFailedEntry<Object, DbContext>> FromUpdateFailed();
		IObservable<IUpdateFailedEntry<Object, DbContext>> FromUpdateFailed(IScheduler scheduler);

		IObservable<IUpdatedEntry     <Object, DbContext>> FromUpdated();
		IObservable<IUpdatedEntry     <Object, DbContext>> FromUpdated(IScheduler scheduler);

	}

	public interface IDbObservable<TEntity>
	where TEntity : class
	{

		IObservable<IInsertingEntry   <TEntity, DbContext>> FromInserting();
		IObservable<IInsertingEntry   <TEntity, DbContext>> FromInserting(IScheduler scheduler);

		IObservable<IInsertFailedEntry<TEntity, DbContext>> FromInsertFailed();
		IObservable<IInsertFailedEntry<TEntity, DbContext>> FromInsertFailed(IScheduler scheduler);

		IObservable<IInsertedEntry    <TEntity, DbContext>> FromInserted();
		IObservable<IInsertedEntry    <TEntity, DbContext>> FromInserted(IScheduler scheduler);

		IObservable<IDeletingEntry    <TEntity, DbContext>> FromDeleting();
		IObservable<IDeletingEntry    <TEntity, DbContext>> FromDeleting(IScheduler scheduler);

		IObservable<IDeleteFailedEntry<TEntity, DbContext>> FromDeleteFailed();
		IObservable<IDeleteFailedEntry<TEntity, DbContext>> FromDeleteFailed(IScheduler scheduler);

		IObservable<IDeletedEntry     <TEntity, DbContext>> FromDeleted();
		IObservable<IDeletedEntry     <TEntity, DbContext>> FromDeleted(IScheduler scheduler);

		IObservable<IUpdatingEntry    <TEntity, DbContext>> FromUpdating();
		IObservable<IUpdatingEntry    <TEntity, DbContext>> FromUpdating(IScheduler scheduler);

		IObservable<IUpdateFailedEntry<TEntity, DbContext>> FromUpdateFailed();
		IObservable<IUpdateFailedEntry<TEntity, DbContext>> FromUpdateFailed(IScheduler scheduler);

		IObservable<IUpdatedEntry     <TEntity, DbContext>> FromUpdated();
		IObservable<IUpdatedEntry     <TEntity, DbContext>> FromUpdated(IScheduler scheduler);

	}

	public interface IDbObservable<TEntity, TDbContext>
	where TEntity : class
	where TDbContext : DbContext
	{

		IObservable<IInsertingEntry   <TEntity, TDbContext>> FromInserting();
		IObservable<IInsertingEntry   <TEntity, TDbContext>> FromInserting(IScheduler scheduler);
		IObservable<IInsertingEntry   <TEntity, DbContext, TService>> FromInserting<TService>();
		IObservable<IInsertingEntry   <TEntity, DbContext, TService>> FromInserting<TService>(IScheduler scheduler);

		IObservable<IInsertFailedEntry<TEntity, TDbContext>> FromInsertFailed();
		IObservable<IInsertFailedEntry<TEntity, TDbContext>> FromInsertFailed(IScheduler scheduler);
		IObservable<IInsertFailedEntry<TEntity, DbContext, TService>> FromInsertFailed<TService>();
		IObservable<IInsertFailedEntry<TEntity, DbContext, TService>> FromInsertFailed<TService>(IScheduler scheduler);

		IObservable<IInsertedEntry    <TEntity, TDbContext>> FromInserted();
		IObservable<IInsertedEntry    <TEntity, TDbContext>> FromInserted(IScheduler scheduler);
		IObservable<IInsertedEntry    <TEntity, DbContext, TService>> FromInserted<TService>();
		IObservable<IInsertedEntry    <TEntity, DbContext, TService>> FromInserted<TService>(IScheduler scheduler);

		IObservable<IDeletingEntry    <TEntity, TDbContext>> FromDeleting();
		IObservable<IDeletingEntry    <TEntity, TDbContext>> FromDeleting(IScheduler scheduler);
		IObservable<IDeletingEntry    <TEntity, DbContext, TService>> FromDeleting<TService>();
		IObservable<IDeletingEntry    <TEntity, DbContext, TService>> FromDeleting<TService>(IScheduler scheduler);

		IObservable<IDeleteFailedEntry<TEntity, TDbContext>> FromDeleteFailed();
		IObservable<IDeleteFailedEntry<TEntity, TDbContext>> FromDeleteFailed(IScheduler scheduler);
		IObservable<IDeleteFailedEntry<TEntity, DbContext, TService>> FromDeleteFailed<TService>();
		IObservable<IDeleteFailedEntry<TEntity, DbContext, TService>> FromDeleteFailed<TService>(IScheduler scheduler);

		IObservable<IDeletedEntry     <TEntity, TDbContext>> FromDeleted();
		IObservable<IDeletedEntry     <TEntity, TDbContext>> FromDeleted(IScheduler scheduler);
		IObservable<IDeletedEntry     <TEntity, DbContext, TService>> FromDeleted<TService>();
		IObservable<IDeletedEntry     <TEntity, DbContext, TService>> FromDeleted<TService>(IScheduler scheduler);

		IObservable<IUpdatingEntry    <TEntity, TDbContext>> FromUpdating();
		IObservable<IUpdatingEntry    <TEntity, TDbContext>> FromUpdating(IScheduler scheduler);
		IObservable<IUpdatingEntry    <TEntity, DbContext, TService>> FromUpdating<TService>();
		IObservable<IUpdatingEntry    <TEntity, DbContext, TService>> FromUpdating<TService>(IScheduler scheduler);

		IObservable<IUpdateFailedEntry<TEntity, TDbContext>> FromUpdateFailed();
		IObservable<IUpdateFailedEntry<TEntity, TDbContext>> FromUpdateFailed(IScheduler scheduler);
		IObservable<IUpdateFailedEntry<TEntity, DbContext, TService>> FromUpdateFailed<TService>();
		IObservable<IUpdateFailedEntry<TEntity, DbContext, TService>> FromUpdateFailed<TService>(IScheduler scheduler);

		IObservable<IUpdatedEntry     <TEntity, TDbContext>> FromUpdated();
		IObservable<IUpdatedEntry     <TEntity, TDbContext>> FromUpdated(IScheduler scheduler);
		IObservable<IUpdatedEntry     <TEntity, DbContext, TService>> FromUpdated<TService>();
		IObservable<IUpdatedEntry     <TEntity, DbContext, TService>> FromUpdated<TService>(IScheduler scheduler);

	}
}