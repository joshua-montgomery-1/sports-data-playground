using System.Text.Json;
using System.Text.Json.Serialization;

namespace SportsData.Clients.MlbStatsApi.Models;

public record TeamRosterResponse
{
    [JsonPropertyName("roster")]
    public IReadOnlyList<RosterEntryDto>? Roster { get; init; }
}

public record RosterEntryDto
{
    [JsonPropertyName("person")]
    public PersonReferenceDto? Person { get; init; }

    [JsonPropertyName("jerseyNumber")]
    public string? JerseyNumber { get; init; }

    [JsonPropertyName("position")]
    public PositionDto? Position { get; init; }

    [JsonPropertyName("status")]
    public RosterStatusDto? Status { get; init; }

    [JsonPropertyName("parentTeamId")]
    public int? ParentTeamId { get; init; }
}

public record RosterStatusDto
{
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }
}

public record TeamStatsResponse
{
    [JsonPropertyName("copyright")]
    public string? Copyright { get; init; }

    [JsonPropertyName("stats")]
    public IReadOnlyList<StatContainerDto>? Stats { get; init; }
}

public record PersonStatsResponse
{
    [JsonPropertyName("copyright")]
    public string? Copyright { get; init; }

    [JsonPropertyName("stats")]
    public IReadOnlyList<StatContainerDto>? Stats { get; init; }
}

public record StatsResponse
{
    [JsonPropertyName("copyright")]
    public string? Copyright { get; init; }

    [JsonPropertyName("stats")]
    public IReadOnlyList<StatContainerDto>? Stats { get; init; }
}

public record StatContainerDto
{
    [JsonPropertyName("type")]
    public StatTypeDto? Type { get; init; }

    [JsonPropertyName("group")]
    public StatGroupDto? Group { get; init; }

    [JsonPropertyName("splits")]
    public IReadOnlyList<StatSplitDto>? Splits { get; init; }
}

public record StatTypeDto
{
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; init; }
}

public record StatGroupDto
{
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; init; }
}

public record StatSplitDto
{
    [JsonPropertyName("season")]
    public string? Season { get; init; }

    [JsonPropertyName("stat")]
    public JsonElement? Stat { get; init; }

    [JsonPropertyName("team")]
    public TeamReferenceDto? Team { get; init; }

    [JsonPropertyName("player")]
    public PersonReferenceDto? Player { get; init; }

    [JsonPropertyName("league")]
    public LeagueReferenceDto? League { get; init; }

    [JsonPropertyName("sport")]
    public SportReferenceDto? Sport { get; init; }
}

public record StatsLeadersResponse
{
    [JsonPropertyName("leagueLeaders")]
    public IReadOnlyList<LeagueLeadersDto>? LeagueLeaders { get; init; }
}

public record LeagueLeadersDto
{
    [JsonPropertyName("leaderCategory")]
    public string? LeaderCategory { get; init; }

    [JsonPropertyName("leaders")]
    public IReadOnlyList<LeaderDto>? Leaders { get; init; }
}

public record LeaderDto
{
    [JsonPropertyName("rank")]
    public int? Rank { get; init; }

    [JsonPropertyName("value")]
    public string? Value { get; init; }

    [JsonPropertyName("season")]
    public string? Season { get; init; }

    [JsonPropertyName("team")]
    public TeamReferenceDto? Team { get; init; }

    [JsonPropertyName("person")]
    public PersonReferenceDto? Person { get; init; }

    [JsonPropertyName("league")]
    public LeagueReferenceDto? League { get; init; }
}

public record StatsStreaksResponse
{
    [JsonPropertyName("streaks")]
    public IReadOnlyList<StreakEntryDto>? Streaks { get; init; }
}

public record StreakEntryDto
{
    [JsonPropertyName("streakType")]
    public string? StreakType { get; init; }

    [JsonPropertyName("streakSpan")]
    public string? StreakSpan { get; init; }

    [JsonPropertyName("streakLength")]
    public int? StreakLength { get; init; }

    [JsonPropertyName("player")]
    public PersonReferenceDto? Player { get; init; }

    [JsonPropertyName("team")]
    public TeamReferenceDto? Team { get; init; }

    [JsonPropertyName("stat")]
    public JsonElement? Stat { get; init; }
}
