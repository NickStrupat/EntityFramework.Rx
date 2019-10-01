using System;
#if EF_CORE
namespace EntityFrameworkCore.Rx
#else
namespace EntityFramework.Rx
#endif
{
	public static class DbObservablesBuilderFactory
	{
		public static IDbObservablesBuilder Create(IServiceProvider serviceProvider) =>
			new DbObservablesBuilder(serviceProvider);
	}
}
