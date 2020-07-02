using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0023.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ConstructorBasedConfigurationServiceProviderProvider"/> implementation of <see cref="IConfigurationServiceProviderProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConstructorBasedConfigurationServiceProviderProvider(this IServiceCollection services, IServiceProvider configurationServiceProvider)
        {
            services.AddSingleton<IConfigurationServiceProviderProvider>(new ConstructorBasedConfigurationServiceProviderProvider(
                configurationServiceProvider));

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ConstructorBasedConfigurationServiceProviderProvider"/> implementation of <see cref="IConfigurationServiceProviderProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IConfigurationServiceProviderProvider> AddConstructorBasedConfigurationServiceProviderProviderAction(this IServiceCollection services, IServiceProvider configurationServiceProvider)
        {
            var serviceAction = ServiceAction.New<IConfigurationServiceProviderProvider>(() => services.AddConstructorBasedConfigurationServiceProviderProvider(
                configurationServiceProvider));

            return serviceAction;
        }
    }
}
