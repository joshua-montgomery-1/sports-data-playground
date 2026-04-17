using System.Text.Json.Serialization;

namespace SportsData.Clients.MlbStatsApi.Models;

public record SportReferenceDto
{
    [JsonPropertyName("id")]
    public int? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("link")]
    public string? Link { get; init; }
}

public record LeagueReferenceDto
{
    [JsonPropertyName("id")]
    public int? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("abbreviation")]
    public string? Abbreviation { get; init; }

    [JsonPropertyName("link")]
    public string? Link { get; init; }
}

public record DivisionReferenceDto
{
    [JsonPropertyName("id")]
    public int? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("abbreviation")]
    public string? Abbreviation { get; init; }

    [JsonPropertyName("link")]
    public string? Link { get; init; }
}

public record TeamReferenceDto
{
    [JsonPropertyName("id")]
    public int? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("link")]
    public string? Link { get; init; }
}

public record PersonReferenceDto
{
    [JsonPropertyName("id")]
    public int? Id { get; init; }

    [JsonPropertyName("fullName")]
    public string? FullName { get; init; }

    [JsonPropertyName("link")]
    public string? Link { get; init; }
}

public record VenueReferenceDto
{
    [JsonPropertyName("id")]
    public int? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("link")]
    public string? Link { get; init; }
}

public record LeagueRecordDto
{
    [JsonPropertyName("wins")]
    public int? Wins { get; init; }

    [JsonPropertyName("losses")]
    public int? Losses { get; init; }

    [JsonPropertyName("pct")]
    public string? Pct { get; init; }
}
