using System;

using R5T.T0064;


namespace R5T.D0023
{
    /// <summary>
    /// Provides the <see cref="IServiceProvider"/> used during startup configuration.
    /// </summary>
    [ServiceDefinitionMarker]
    public interface IConfigurationServiceProviderProvider : IServiceDefinition
    {
        IServiceProvider GetConfigurationServiceProvider();
    }
}
