using System;


namespace R5T.D0023.Default
{
    public class ConstructorBasedConfigurationServiceProviderProvider : IConfigurationServiceProviderProvider
    {
        private IServiceProvider ServiceProvider { get; }


        public ConstructorBasedConfigurationServiceProviderProvider(IServiceProvider serviceProvider)
        {
            this.ServiceProvider = serviceProvider;
        }

        public IServiceProvider GetConfigurationServiceProvider()
        {
            return this.ServiceProvider;
        }
    }
}
