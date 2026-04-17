using System.Text.Json.Serialization;

namespace SportsData.Clients.MlbStatsApi.Models;

public record ScheduleResponse
{
    [JsonPropertyName("totalItems")]
    public int? TotalItems { get; init; }

    [JsonPropertyName("totalEvents")]
    public int? TotalEvents { get; init; }

    [JsonPropertyName("totalGames")]
    public int? TotalGames { get; init; }

    [JsonPropertyName("totalGamesInProgress")]
    public int? TotalGamesInProgress { get; init; }

    [JsonPropertyName("dates")]
    public IReadOnlyList<ScheduleDateDto>? Dates { get; init; }
}

public record ScheduleDateDto
{
    [JsonPropertyName("date")]
    public DateOnly? Date { get; init; }

    [JsonPropertyName("totalItems")]
    public int? TotalItems { get; init; }

    [JsonPropertyName("totalEvents")]
    public int? TotalEvents { get; init; }

    [JsonPropertyName("totalGames")]
    public int? TotalGames { get; init; }

    [JsonPropertyName("totalGamesInProgress")]
    public int? TotalGamesInProgress { get; init; }

    [JsonPropertyName("games")]
    public IReadOnlyList<ScheduledGameDto>? Games { get; init; }
}

public record ScheduledGameDto
{
    [JsonPropertyName("gamePk")]
    public int? GamePk { get; init; }

    [JsonPropertyName("gameGuid")]
    public string? GameGuid { get; init; }

    [JsonPropertyName("link")]
    public string? Link { get; init; }

    [JsonPropertyName("gameType")]
    public string? GameType { get; init; }

    [JsonPropertyName("season")]
    public string? Season { get; init; }

    [JsonPropertyName("gameDate")]
    public DateTimeOffset? GameDate { get; init; }

    [JsonPropertyName("status")]
    public GameStatusDto? Status { get; init; }

    [JsonPropertyName("teams")]
    public ScheduledTeamsDto? Teams { get; init; }

    [JsonPropertyName("venue")]
    public VenueReferenceDto? Venue { get; init; }
}

public record GameStatusDto
{
    [JsonPropertyName("abstractGameState")]
    public string? AbstractGameState { get; init; }

    [JsonPropertyName("codedGameState")]
    public string? CodedGameState { get; init; }

    [JsonPropertyName("detailedState")]
    public string? DetailedState { get; init; }

    [JsonPropertyName("statusCode")]
    public string? StatusCode { get; init; }
}

public record ScheduledTeamsDto
{
    [JsonPropertyName("away")]
    public ScheduledTeamDto? Away { get; init; }

    [JsonPropertyName("home")]
    public ScheduledTeamDto? Home { get; init; }
}

public record ScheduledTeamDto
{
    [JsonPropertyName("score")]
    public int? Score { get; init; }

    [JsonPropertyName("team")]
    public TeamReferenceDto? Team { get; init; }

    [JsonPropertyName("leagueRecord")]
    public LeagueRecordDto? LeagueRecord { get; init; }

    [JsonPropertyName("isWinner")]
    public bool? IsWinner { get; init; }
}
