#if EF_CORE
using Microsoft.EntityFrameworkCore;
namespace EntityFrameworkCore.Rx.AspNetCore
#else
using System.Data.Entity;
namespace EntityFramework.Rx.AspNetCore
#endif
{
	public interface IDbObservablesBuilder
	{
		IDbObservable<TEntity, TDbContext> DbObservables<TEntity, TDbContext>()
			where TEntity : class
			where TDbContext : DbContext;

		IDbObservable<TEntity> DbObservables<TEntity>()
			where TEntity : class;

		IDbObservable DbObservables();
	}
}