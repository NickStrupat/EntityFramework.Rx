using Microsoft.Extensions.DependencyInjection;
#if EF_CORE
namespace EntityFrameworkCore.Rx
#else
namespace EntityFramework.Rx
#endif
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddDbObservables(this IServiceCollection serviceCollection) =>
			serviceCollection
				.AddSingleton(typeof(DbObservable<,>))
				.AddSingleton(typeof(DbObservable<>))
				.AddSingleton(typeof(DbObservable))
				.AddSingleton(typeof(IDbObservable<,>), typeof(DbObservable<,>))
				.AddSingleton(typeof(IDbObservable<>), typeof(DbObservable<>))
				.AddSingleton(typeof(IDbObservable), typeof(DbObservable));
	}
}
