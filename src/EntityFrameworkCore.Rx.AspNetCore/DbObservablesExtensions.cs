using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
#if EF_CORE
using EntityFrameworkCore.Triggers.AspNetCore;
namespace EntityFrameworkCore.Rx.AspNetCore
#else
using EntityFramework.Triggers.AspNetCore;
namespace EntityFramework.Rx.AspNetCore
#endif
{
	public static class DbObservablesExtensions
	{
		public static IServiceCollection AddDbObservables(this IServiceCollection serviceCollection) =>
			serviceCollection
				.AddTriggers()
				.AddSingleton(typeof(DbObservable<,>))
				.AddSingleton(typeof(DbObservable<>))
				.AddSingleton(typeof(DbObservable))
				.AddSingleton(typeof(IDbObservable<,>), typeof(DbObservable<,>))
				.AddSingleton(typeof(IDbObservable<>), typeof(DbObservable<>))
				.AddSingleton(typeof(IDbObservable), typeof(DbObservable));

		public static IApplicationBuilder UseDbObservables(this IApplicationBuilder app, Action<IDbObservablesBuilder> configureDbObservables)
		{
			if (configureDbObservables == null)
				throw new ArgumentNullException(nameof(configureDbObservables));
			configureDbObservables.Invoke(new DbObservablesBuilder(app.ApplicationServices));
			return app;
		}
	}
}
