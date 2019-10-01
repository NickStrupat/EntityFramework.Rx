using System;
using Microsoft.AspNetCore.Builder;
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
		public static IApplicationBuilder UseDbObservables(this IApplicationBuilder app, Action<IDbObservablesBuilder> configureDbObservables)
		{
			if (configureDbObservables == null)
				throw new ArgumentNullException(nameof(configureDbObservables));
			configureDbObservables.Invoke(DbObservablesBuilderFactory.Create(app.ApplicationServices));
			return app;
		}
	}
}
