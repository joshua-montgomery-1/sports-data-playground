using System.Text.Json.Serialization;

namespace SportsData.Clients.MlbStatsApi.Models;

public record TeamDto
{
    [JsonPropertyName("id")]
    public int? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("teamName")]
    public string? TeamName { get; init; }

    [JsonPropertyName("locationName")]
    public string? LocationName { get; init; }

    [JsonPropertyName("abbreviation")]
    public string? Abbreviation { get; init; }

    [JsonPropertyName("link")]
    public string? Link { get; init; }

    [JsonPropertyName("firstYearOfPlay")]
    public string? FirstYearOfPlay { get; init; }

    [JsonPropertyName("active")]
    public bool? Active { get; init; }

    [JsonPropertyName("sport")]
    public SportReferenceDto? Sport { get; init; }

    [JsonPropertyName("league")]
    public LeagueReferenceDto? League { get; init; }

    [JsonPropertyName("division")]
    public DivisionReferenceDto? Division { get; init; }

    [JsonPropertyName("venue")]
    public VenueReferenceDto? Venue { get; init; }
}

public record TeamsResponse
{
    [JsonPropertyName("teams")]
    public IReadOnlyList<TeamDto>? Teams { get; init; }
}
