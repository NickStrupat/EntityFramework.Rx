using System;

#if EF_CORE
using EntityFrameworkCore.Triggers;
namespace EntityFrameworkCore.Rx
#else
using EntityFramework.Triggers;
namespace EntityFramework.Rx
#endif
{
	public static class ServiceProviderExtensions
	{
		public static void AddDbObservables<TContainer>(this TContainer container, Action<(TContainer Container, Type ServiceType, Type ImplementationType)> registerServiceAndImplementation)
			where TContainer : IServiceProvider
		{
			if (registerServiceAndImplementation == null)
				throw new ArgumentNullException(nameof(registerServiceAndImplementation));
			container.AddTriggers(registerServiceAndImplementation);
			registerServiceAndImplementation((container, typeof(IDbObservable<,>), typeof(DbObservable<,>)));
			registerServiceAndImplementation((container, typeof(IDbObservable<>), typeof(DbObservable<>)));
			registerServiceAndImplementation((container, typeof(IDbObservable), typeof(DbObservable)));
		}
	}
}
