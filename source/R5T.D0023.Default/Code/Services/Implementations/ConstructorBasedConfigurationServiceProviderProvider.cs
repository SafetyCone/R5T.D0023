using System;

using R5T.T0064;


namespace R5T.D0023.Default
{
    [ServiceImplementationMarker]
    public class ConstructorBasedConfigurationServiceProviderProvider : IConfigurationServiceProviderProvider, IServiceImplementation
    {
        private IServiceProvider ServiceProvider { get; }


        public ConstructorBasedConfigurationServiceProviderProvider(
            IServiceProvider serviceProvider)
        {
            this.ServiceProvider = serviceProvider;
        }

        public IServiceProvider GetConfigurationServiceProvider()
        {
            return this.ServiceProvider;
        }
    }
}
