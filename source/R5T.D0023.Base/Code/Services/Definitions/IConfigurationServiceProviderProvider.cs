using System;


namespace R5T.D0023.Base
{
    /// <summary>
    /// Provides the <see cref="IServiceProvider"/> used during startup configuration.
    /// </summary>
    public interface IConfigurationServiceProviderProvider
    {
        IServiceProvider GetConfigurationServiceProvider();
    }
}
