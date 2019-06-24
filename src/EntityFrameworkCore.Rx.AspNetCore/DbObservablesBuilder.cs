using System;
using Microsoft.Extensions.DependencyInjection;
#if EF_CORE
using Microsoft.EntityFrameworkCore;
namespace EntityFrameworkCore.Rx.AspNetCore
#else
using System.Data.Entity;
namespace EntityFramework.Rx.AspNetCore
#endif
{
	internal class DbObservablesBuilder : IDbObservablesBuilder
	{
		private readonly IServiceProvider serviceProvider;

		public DbObservablesBuilder(IServiceProvider serviceProvider) => this.serviceProvider = serviceProvider;

		public IDbObservable<TEntity, TDbContext> DbObservables<TEntity, TDbContext>()
			where TEntity : class
			where TDbContext : DbContext =>
		serviceProvider.GetRequiredService<IDbObservable<TEntity, TDbContext>>();

		public IDbObservable<TEntity> DbObservables<TEntity>()
		where TEntity : class =>
			serviceProvider.GetRequiredService<IDbObservable<TEntity>>();

		public IDbObservable DbObservables() =>
			serviceProvider.GetRequiredService<IDbObservable>();
	}
}
