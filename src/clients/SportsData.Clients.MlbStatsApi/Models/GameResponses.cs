using System.Text.Json;
using System.Text.Json.Serialization;

namespace SportsData.Clients.MlbStatsApi.Models;

public record GameBoxscoreResponse
{
    [JsonPropertyName("teams")]
    public JsonElement? Teams { get; init; }

    [JsonPropertyName("officials")]
    public IReadOnlyList<JsonElement>? Officials { get; init; }

    [JsonPropertyName("info")]
    public IReadOnlyList<JsonElement>? Info { get; init; }
}

public record GameLinescoreResponse
{
    [JsonPropertyName("currentInning")]
    public int? CurrentInning { get; init; }

    [JsonPropertyName("currentInningOrdinal")]
    public string? CurrentInningOrdinal { get; init; }

    [JsonPropertyName("inningState")]
    public string? InningState { get; init; }

    [JsonPropertyName("innings")]
    public IReadOnlyList<JsonElement>? Innings { get; init; }

    [JsonPropertyName("teams")]
    public JsonElement? Teams { get; init; }
}

public record GamePlayByPlayResponse
{
    [JsonPropertyName("allPlays")]
    public IReadOnlyList<JsonElement>? AllPlays { get; init; }

    [JsonPropertyName("scoringPlays")]
    public IReadOnlyList<int>? ScoringPlays { get; init; }

    [JsonPropertyName("playsByInning")]
    public IReadOnlyList<JsonElement>? PlaysByInning { get; init; }
}

public record GameDecisionsResponse
{
    [JsonPropertyName("winner")]
    public PersonReferenceDto? Winner { get; init; }

    [JsonPropertyName("loser")]
    public PersonReferenceDto? Loser { get; init; }

    [JsonPropertyName("save")]
    public PersonReferenceDto? Save { get; init; }
}

public record GameContentResponse
{
    [JsonPropertyName("copyright")]
    public string? Copyright { get; init; }

    [JsonPropertyName("link")]
    public string? Link { get; init; }

    [JsonPropertyName("editorial")]
    public JsonElement? Editorial { get; init; }

    [JsonPropertyName("media")]
    public JsonElement? Media { get; init; }
}

public record GameFeedLiveResponse
{
    [JsonPropertyName("gamePk")]
    public int? GamePk { get; init; }

    [JsonPropertyName("link")]
    public string? Link { get; init; }

    [JsonPropertyName("metaData")]
    public JsonElement? MetaData { get; init; }

    [JsonPropertyName("gameData")]
    public JsonElement? GameData { get; init; }

    [JsonPropertyName("liveData")]
    public JsonElement? LiveData { get; init; }
}
