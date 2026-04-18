using System.Net;
using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace SportsData.Clients.MlbStatsApi;

public static class MlbStatsApiServiceCollectionExtensions
{
    private static readonly Uri BaseAddress = new("https://statsapi.mlb.com/api/v1/");

    public static IHttpClientBuilder AddMlbStatsApiClient(
        this IServiceCollection services,
        Action<RefitSettings> configureRefitSettings)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(configureRefitSettings);

        RefitSettings effectiveRefitSettings = CreateDefaultRefitSettings();
        configureRefitSettings(effectiveRefitSettings);

        return services.AddMlbStatsApiClient(effectiveRefitSettings);
    }

    public static IHttpClientBuilder AddMlbStatsApiClient(
        this IServiceCollection services,
        RefitSettings? refitSettings = null)
    {
        ArgumentNullException.ThrowIfNull(services);

        RefitSettings effectiveRefitSettings = refitSettings ?? CreateDefaultRefitSettings();

        return services
            .AddRefitClient<IMlbStatsApiClient>(effectiveRefitSettings)
            .ConfigureHttpClient(client => client.BaseAddress = BaseAddress)
            .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            });
    }

    private static RefitSettings CreateDefaultRefitSettings()
    {
        JsonSerializerOptions serializerOptions = new(JsonSerializerDefaults.Web)
        {
            TypeInfoResolver = MlbStatsApiJsonSerializerContext.Default
        };

        return new RefitSettings
        {
            ContentSerializer = new SystemTextJsonContentSerializer(serializerOptions)
        };
    }
}
