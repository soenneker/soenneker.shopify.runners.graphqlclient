using Microsoft.Extensions.DependencyInjection;
using Soenneker.GraphQL.Generator.Registrars;
using Soenneker.GraphQl.Schema.Conversion.Registrars;
using Soenneker.GraphQl.Schema.Download.Registrars;
using Soenneker.Managers.Runners.Registrars;
using Soenneker.Utils.File.Download.Registrars;
using Soenneker.Shopify.Runners.GraphQlClient.Utils;
using Soenneker.Shopify.Runners.GraphQlClient.Utils.Abstract;

namespace Soenneker.Shopify.Runners.GraphQlClient;

/// <summary>
/// Console type startup
/// </summary>
public static class Startup
{
    // This method gets called by the runtime. Use this method to add services to the container.
    /// <summary>
    /// Configures services.
    /// </summary>
    /// <param name="services">The service collection.</param>
    public static void ConfigureServices(IServiceCollection services)
    {
        services.SetupIoC();
    }

    /// <summary>
    /// Sets up io c.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <returns>The result of the operation.</returns>
    public static IServiceCollection SetupIoC(this IServiceCollection services)
    {
        services.AddHostedService<ConsoleHostedService>()
                .AddSingleton<IFileOperationsUtil, FileOperationsUtil>()
                .AddRunnersManagerAsSingleton()
                .AddFileDownloadUtilAsSingleton()
                .AddGraphQlGeneratorAsSingleton()
                .AddGraphQlSchemaDownloadUtilAsSingleton()
                .AddGraphQlSchemaConversionUtilAsSingleton();

        return services;
    }
}