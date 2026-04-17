using Refit;
using SportsData.Clients.MlbStatsApi.Models;

namespace SportsData.Clients.MlbStatsApi;

[Headers("Accept: application/json")]
public interface IMlbStatsApiClient
{
    [Get("/sports")]
    Task<ApiResponse<SportsResponse>> GetSportsAsync(
        [AliasAs("sportId")] int? sportId = null,
        CancellationToken cancellationToken = default);

    [Get("/leagues")]
    Task<ApiResponse<LeaguesResponse>> GetLeaguesAsync(
        [AliasAs("sportId")] int? sportId = null,
        CancellationToken cancellationToken = default);

    [Get("/teams")]
    Task<ApiResponse<TeamsResponse>> GetTeamsAsync(
        [AliasAs("sportId")] int? sportId = null,
        [AliasAs("leagueId")] int? leagueId = null,
        [AliasAs("season")] int? season = null,
        [AliasAs("activeStatus")] string? activeStatus = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/teams/{teamId}")]
    Task<ApiResponse<TeamsResponse>> GetTeamByIdAsync(
        [AliasAs("teamId")] int teamId,
        [AliasAs("season")] int? season = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/people/{personId}")]
    Task<ApiResponse<PeopleResponse>> GetPersonByIdAsync(
        [AliasAs("personId")] int personId,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/schedule")]
    Task<ApiResponse<ScheduleResponse>> GetScheduleAsync(
        [AliasAs("sportId")] int? sportId = null,
        [AliasAs("leagueId")] int? leagueId = null,
        [AliasAs("season")] int? season = null,
        [AliasAs("teamId")] int? teamId = null,
        [AliasAs("date")] DateOnly? date = null,
        [AliasAs("startDate")] DateOnly? startDate = null,
        [AliasAs("endDate")] DateOnly? endDate = null,
        [AliasAs("gamePk")] int? gamePk = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/standings")]
    Task<ApiResponse<StandingsResponse>> GetStandingsAsync(
        [AliasAs("sportId")] int? sportId = null,
        [AliasAs("leagueId")] int? leagueId = null,
        [AliasAs("season")] int? season = null,
        [AliasAs("date")] DateOnly? date = null,
        [AliasAs("standingsType")] string? standingsType = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/teams/{teamId}/roster")]
    Task<ApiResponse<TeamRosterResponse>> GetTeamRosterAsync(
        [AliasAs("teamId")] int teamId,
        [AliasAs("rosterType")] string? rosterType = null,
        [AliasAs("season")] int? season = null,
        [AliasAs("date")] DateOnly? date = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/teams/{teamId}/stats")]
    Task<ApiResponse<TeamStatsResponse>> GetTeamStatsAsync(
        [AliasAs("teamId")] int teamId,
        [AliasAs("stats")] string? stats = null,
        [AliasAs("group")] string? group = null,
        [AliasAs("season")] int? season = null,
        [AliasAs("gameType")] string? gameType = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/people/{personId}/stats")]
    Task<ApiResponse<PersonStatsResponse>> GetPersonStatsAsync(
        [AliasAs("personId")] int personId,
        [AliasAs("stats")] string? stats = null,
        [AliasAs("group")] string? group = null,
        [AliasAs("season")] int? season = null,
        [AliasAs("gameType")] string? gameType = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/people/search")]
    Task<ApiResponse<PeopleResponse>> SearchPeopleAsync(
        [AliasAs("names")] string? names = null,
        [AliasAs("sportId")] int? sportId = null,
        [AliasAs("active")] bool? active = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/stats")]
    Task<ApiResponse<StatsResponse>> GetStatsAsync(
        [AliasAs("stats")] string? stats = null,
        [AliasAs("group")] string? group = null,
        [AliasAs("sportIds")] string? sportIds = null,
        [AliasAs("leagueIds")] string? leagueIds = null,
        [AliasAs("season")] int? season = null,
        [AliasAs("gameType")] string? gameType = null,
        [AliasAs("playerPool")] string? playerPool = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/stats/leaders")]
    Task<ApiResponse<StatsLeadersResponse>> GetStatsLeadersAsync(
        [AliasAs("leaderCategories")] string? leaderCategories = null,
        [AliasAs("statGroup")] string? statGroup = null,
        [AliasAs("limit")] int? limit = null,
        [AliasAs("season")] int? season = null,
        [AliasAs("sportId")] int? sportId = null,
        [AliasAs("leagueId")] int? leagueId = null,
        [AliasAs("gameTypes")] string? gameTypes = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/stats/streaks")]
    Task<ApiResponse<StatsStreaksResponse>> GetStatsStreaksAsync(
        [AliasAs("streakType")] string? streakType = null,
        [AliasAs("streakSpan")] string? streakSpan = null,
        [AliasAs("statType")] string? statType = null,
        [AliasAs("teamId")] int? teamId = null,
        [AliasAs("sportId")] int? sportId = null,
        [AliasAs("season")] int? season = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/game/{gamePk}/boxscore")]
    Task<ApiResponse<GameBoxscoreResponse>> GetGameBoxscoreAsync(
        [AliasAs("gamePk")] int gamePk,
        [AliasAs("timecode")] string? timecode = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/game/{gamePk}/linescore")]
    Task<ApiResponse<GameLinescoreResponse>> GetGameLinescoreAsync(
        [AliasAs("gamePk")] int gamePk,
        [AliasAs("timecode")] string? timecode = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/game/{gamePk}/playByPlay")]
    Task<ApiResponse<GamePlayByPlayResponse>> GetGamePlayByPlayAsync(
        [AliasAs("gamePk")] int gamePk,
        [AliasAs("timecode")] string? timecode = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/game/{gamePk}/decisions")]
    Task<ApiResponse<GameDecisionsResponse>> GetGameDecisionsAsync(
        [AliasAs("gamePk")] int gamePk,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/game/{gamePk}/content")]
    Task<ApiResponse<GameContentResponse>> GetGameContentAsync(
        [AliasAs("gamePk")] int gamePk,
        [AliasAs("language")] string? language = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/game/{gamePk}/feed/live")]
    Task<ApiResponse<GameFeedLiveResponse>> GetGameFeedLiveAsync(
        [AliasAs("gamePk")] int gamePk,
        [AliasAs("timecode")] string? timecode = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/venues")]
    Task<ApiResponse<VenuesResponse>> GetVenuesAsync(
        [AliasAs("sportId")] int? sportId = null,
        [AliasAs("activeStatus")] string? activeStatus = null,
        [AliasAs("season")] int? season = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/venues/{venueId}")]
    Task<ApiResponse<VenuesResponse>> GetVenueByIdAsync(
        [AliasAs("venueId")] int venueId,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/positions")]
    Task<ApiResponse<PositionsResponse>> GetPositionsAsync(
        [AliasAs("sportId")] int? sportId = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/gameTypes")]
    Task<ApiResponse<GameTypesResponse>> GetGameTypesAsync(
        [AliasAs("sportId")] int? sportId = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/awards")]
    Task<ApiResponse<AwardsResponse>> GetAwardsAsync(
        [AliasAs("sportId")] int? sportId = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/awards/{awardId}/recipients")]
    Task<ApiResponse<AwardRecipientsResponse>> GetAwardRecipientsAsync(
        [AliasAs("awardId")] string awardId,
        [AliasAs("season")] int? season = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/draft/{year}")]
    Task<ApiResponse<DraftResponse>> GetDraftAsync(
        [AliasAs("year")] int year,
        [AliasAs("round")] int? round = null,
        [AliasAs("name")] string? name = null,
        [AliasAs("teamId")] int? teamId = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/draft/{year}/latest")]
    Task<ApiResponse<DraftResponse>> GetLatestDraftAsync(
        [AliasAs("year")] int year,
        [AliasAs("round")] int? round = null,
        [AliasAs("name")] string? name = null,
        [AliasAs("teamId")] int? teamId = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);

    [Get("/transactions")]
    Task<ApiResponse<TransactionsResponse>> GetTransactionsAsync(
        [AliasAs("sportId")] int? sportId = null,
        [AliasAs("leagueId")] int? leagueId = null,
        [AliasAs("teamId")] int? teamId = null,
        [AliasAs("playerId")] int? playerId = null,
        [AliasAs("transactionId")] int? transactionId = null,
        [AliasAs("transactionType")] string? transactionType = null,
        [AliasAs("date")] DateOnly? date = null,
        [AliasAs("startDate")] DateOnly? startDate = null,
        [AliasAs("endDate")] DateOnly? endDate = null,
        [AliasAs("hydrate")] string? hydrate = null,
        CancellationToken cancellationToken = default);
}
