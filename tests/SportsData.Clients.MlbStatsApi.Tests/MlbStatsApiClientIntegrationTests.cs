using Refit;

namespace SportsData.Clients.MlbStatsApi.Tests;

public class MlbStatsApiClientIntegrationTests
{
    private const string BaseUrl = "https://statsapi.mlb.com/api/v1/";
    private static readonly HttpClient SharedHttpClient = new()
    {
        BaseAddress = new Uri(BaseUrl),
        Timeout = TimeSpan.FromSeconds(20)
    };
    private static readonly IMlbStatsApiClient Client = RestService.For<IMlbStatsApiClient>(SharedHttpClient);

    [Fact]
    public async Task GetSportsAsync_ReturnsSuccessStatusCode()
    {
        var response = await Client.GetSportsAsync(cancellationToken: TestContext.Current.CancellationToken);
        Assert.True(response.IsSuccessStatusCode, $"Expected success but got {(int)response.StatusCode}.");
    }

    [Fact]
    public async Task GetTeamsAsync_ReturnsSuccessStatusCode()
    {
        var response = await Client.GetTeamsAsync(
            sportId: 1,
            season: DateTime.UtcNow.Year,
            cancellationToken: TestContext.Current.CancellationToken);
        Assert.True(response.IsSuccessStatusCode, $"Expected success but got {(int)response.StatusCode}.");
    }

    [Fact]
    public async Task GetScheduleAsync_ReturnsSuccessStatusCode()
    {
        var response = await Client.GetScheduleAsync(
            sportId: 1,
            date: DateOnly.FromDateTime(DateTime.UtcNow),
            cancellationToken: TestContext.Current.CancellationToken);
        Assert.True(response.IsSuccessStatusCode, $"Expected success but got {(int)response.StatusCode}.");
    }
}
