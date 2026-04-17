using System.Text.Json.Serialization;

namespace SportsData.Clients.MlbStatsApi.Models;

public record SportDto
{
    [JsonPropertyName("id")]
    public int? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("link")]
    public string? Link { get; init; }

    [JsonPropertyName("abbreviation")]
    public string? Abbreviation { get; init; }
}

public record SportsResponse
{
    [JsonPropertyName("sports")]
    public IReadOnlyList<SportDto>? Sports { get; init; }
}
