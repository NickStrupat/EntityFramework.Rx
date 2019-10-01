#if EF_CORE
using Microsoft.EntityFrameworkCore;
namespace EntityFrameworkCore.Rx
#else
using System.Data.Entity;
namespace EntityFramework.Rx
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