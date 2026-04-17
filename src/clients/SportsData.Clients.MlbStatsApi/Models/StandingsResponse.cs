using System.Text.Json;
using System.Text.Json.Serialization;

namespace SportsData.Clients.MlbStatsApi.Models;

public record StandingsResponse
{
    [JsonPropertyName("records")]
    public IReadOnlyList<StandingsRecordDto>? Records { get; init; }
}

public record StandingsRecordDto
{
    [JsonPropertyName("standingsType")]
    public string? StandingsType { get; init; }

    [JsonPropertyName("league")]
    public LeagueReferenceDto? League { get; init; }

    [JsonPropertyName("division")]
    public DivisionReferenceDto? Division { get; init; }

    [JsonPropertyName("sport")]
    public SportReferenceDto? Sport { get; init; }

    [JsonPropertyName("lastUpdated")]
    public DateTimeOffset? LastUpdated { get; init; }

    [JsonPropertyName("teamRecords")]
    public IReadOnlyList<StandingsTeamRecordDto>? TeamRecords { get; init; }
}

public record StandingsTeamRecordDto
{
    [JsonPropertyName("team")]
    public TeamReferenceDto? Team { get; init; }

    [JsonPropertyName("season")]
    public string? Season { get; init; }

    [JsonPropertyName("streak")]
    public StreakDto? Streak { get; init; }

    [JsonPropertyName("divisionRank")]
    public string? DivisionRank { get; init; }

    [JsonPropertyName("leagueRank")]
    public string? LeagueRank { get; init; }

    [JsonPropertyName("sportRank")]
    public string? SportRank { get; init; }

    [JsonPropertyName("gamesPlayed")]
    public int? GamesPlayed { get; init; }

    [JsonPropertyName("gamesBack")]
    public string? GamesBack { get; init; }

    [JsonPropertyName("wildCardGamesBack")]
    public string? WildCardGamesBack { get; init; }

    [JsonPropertyName("leagueGamesBack")]
    public string? LeagueGamesBack { get; init; }

    [JsonPropertyName("divisionGamesBack")]
    public string? DivisionGamesBack { get; init; }

    [JsonPropertyName("sportGamesBack")]
    public string? SportGamesBack { get; init; }

    [JsonPropertyName("leagueRecord")]
    public LeagueRecordDto? LeagueRecord { get; init; }

    [JsonPropertyName("records")]
    public JsonElement? Records { get; init; }

    [JsonPropertyName("runDifferential")]
    public string? RunDifferential { get; init; }

    [JsonPropertyName("winningPercentage")]
    public string? WinningPercentage { get; init; }
}

public record StreakDto
{
    [JsonPropertyName("streakType")]
    public string? StreakType { get; init; }

    [JsonPropertyName("streakNumber")]
    public int? StreakNumber { get; init; }

    [JsonPropertyName("streakCode")]
    public string? StreakCode { get; init; }
}
