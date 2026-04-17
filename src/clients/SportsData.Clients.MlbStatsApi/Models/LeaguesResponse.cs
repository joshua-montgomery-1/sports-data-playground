using System.Text.Json.Serialization;

namespace SportsData.Clients.MlbStatsApi.Models;

public record LeagueDto
{
    [JsonPropertyName("id")]
    public int? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("abbreviation")]
    public string? Abbreviation { get; init; }

    [JsonPropertyName("link")]
    public string? Link { get; init; }

    [JsonPropertyName("sport")]
    public SportReferenceDto? Sport { get; init; }
}

public record LeaguesResponse
{
    [JsonPropertyName("leagues")]
    public IReadOnlyList<LeagueDto>? Leagues { get; init; }
}
