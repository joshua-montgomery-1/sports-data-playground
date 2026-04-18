using System.Text.Json.Serialization;
using SportsData.Clients.MlbStatsApi.Models;

namespace SportsData.Clients.MlbStatsApi;

[JsonSourceGenerationOptions(
    PropertyNameCaseInsensitive = true,
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
[JsonSerializable(typeof(SportsResponse))]
[JsonSerializable(typeof(LeaguesResponse))]
[JsonSerializable(typeof(TeamsResponse))]
[JsonSerializable(typeof(PeopleResponse))]
[JsonSerializable(typeof(ScheduleResponse))]
[JsonSerializable(typeof(StandingsResponse))]
[JsonSerializable(typeof(TeamRosterResponse))]
[JsonSerializable(typeof(TeamStatsResponse))]
[JsonSerializable(typeof(PersonStatsResponse))]
[JsonSerializable(typeof(StatsResponse))]
[JsonSerializable(typeof(StatsLeadersResponse))]
[JsonSerializable(typeof(StatsStreaksResponse))]
[JsonSerializable(typeof(GameBoxscoreResponse))]
[JsonSerializable(typeof(GameLinescoreResponse))]
[JsonSerializable(typeof(GamePlayByPlayResponse))]
[JsonSerializable(typeof(GameDecisionsResponse))]
[JsonSerializable(typeof(GameContentResponse))]
[JsonSerializable(typeof(GameFeedLiveResponse))]
[JsonSerializable(typeof(VenuesResponse))]
[JsonSerializable(typeof(PositionsResponse))]
[JsonSerializable(typeof(GameTypesResponse))]
[JsonSerializable(typeof(AwardsResponse))]
[JsonSerializable(typeof(AwardRecipientsResponse))]
[JsonSerializable(typeof(DraftResponse))]
[JsonSerializable(typeof(TransactionsResponse))]
internal partial class MlbStatsApiJsonSerializerContext : JsonSerializerContext
{
}
