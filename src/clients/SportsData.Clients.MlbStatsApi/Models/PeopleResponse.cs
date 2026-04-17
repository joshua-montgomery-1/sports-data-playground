using System.Text.Json.Serialization;

namespace SportsData.Clients.MlbStatsApi.Models;

public record HandednessDto
{
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }
}

public record PositionDto
{
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonPropertyName("abbreviation")]
    public string? Abbreviation { get; init; }
}

public record PersonDto
{
    [JsonPropertyName("id")]
    public int? Id { get; init; }

    [JsonPropertyName("fullName")]
    public string? FullName { get; init; }

    [JsonPropertyName("firstName")]
    public string? FirstName { get; init; }

    [JsonPropertyName("lastName")]
    public string? LastName { get; init; }

    [JsonPropertyName("primaryNumber")]
    public string? PrimaryNumber { get; init; }

    [JsonPropertyName("birthDate")]
    public DateTimeOffset? BirthDate { get; init; }

    [JsonPropertyName("currentAge")]
    public int? CurrentAge { get; init; }

    [JsonPropertyName("active")]
    public bool? Active { get; init; }

    [JsonPropertyName("batSide")]
    public HandednessDto? BatSide { get; init; }

    [JsonPropertyName("pitchHand")]
    public HandednessDto? PitchHand { get; init; }

    [JsonPropertyName("primaryPosition")]
    public PositionDto? PrimaryPosition { get; init; }

    [JsonPropertyName("link")]
    public string? Link { get; init; }
}

public record PeopleResponse
{
    [JsonPropertyName("people")]
    public IReadOnlyList<PersonDto>? People { get; init; }
}
