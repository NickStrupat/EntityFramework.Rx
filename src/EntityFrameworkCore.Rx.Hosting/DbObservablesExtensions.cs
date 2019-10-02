using System;
using Microsoft.Extensions.Hosting;
#if EF_CORE
namespace EntityFrameworkCore.Rx.Hosting
#else
namespace EntityFramework.Rx.Hosting
#endif
{
	public static class DbObservablesExtensions
	{
		public static IHost UseDbObservables(this IHost host, Action<IDbObservablesBuilder> configureDbObservables)
		{
			if (configureDbObservables == null)
				throw new ArgumentNullException(nameof(configureDbObservables));
			var dbObservablesBuilder = DbObservablesBuilderFactory.Create(host.Services);
			configureDbObservables.Invoke(dbObservablesBuilder);
			return host;
		}
	}
}
