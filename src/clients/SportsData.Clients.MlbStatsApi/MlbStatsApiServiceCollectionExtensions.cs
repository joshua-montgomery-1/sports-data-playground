using System.Net;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace SportsData.Clients.MlbStatsApi;

public static class MlbStatsApiServiceCollectionExtensions
{
    private static readonly Uri BaseAddress = new("https://statsapi.mlb.com/api/v1/");

    public static IHttpClientBuilder AddMlbStatsApiClient(
        this IServiceCollection services,
        RefitSettings? refitSettings = null)
    {
        ArgumentNullException.ThrowIfNull(services);

        return services
            .AddRefitClient<IMlbStatsApiClient>(refitSettings)
            .ConfigureHttpClient(client => client.BaseAddress = BaseAddress)
            .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            });
    }
}
