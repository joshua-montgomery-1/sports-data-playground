using System.Text.Json;
using System.Text.Json.Serialization;

namespace SportsData.Clients.MlbStatsApi.Models;

public record VenuesResponse
{
    [JsonPropertyName("venues")]
    public IReadOnlyList<VenueDto>? Venues { get; init; }
}

public record VenueDto
{
    [JsonPropertyName("id")]
    public int? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("link")]
    public string? Link { get; init; }

    [JsonPropertyName("active")]
    public bool? Active { get; init; }

    [JsonPropertyName("location")]
    public JsonElement? Location { get; init; }

    [JsonPropertyName("timezone")]
    public JsonElement? Timezone { get; init; }
}

public record PositionsResponse
{
    [JsonPropertyName("positions")]
    public IReadOnlyList<PositionDto>? Positions { get; init; }
}

public record GameTypesResponse
{
    [JsonPropertyName("gameTypes")]
    public IReadOnlyList<GameTypeDto>? GameTypes { get; init; }
}

public record GameTypeDto
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }
}

public record AwardsResponse
{
    [JsonPropertyName("awards")]
    public IReadOnlyList<AwardDto>? Awards { get; init; }
}

public record AwardRecipientsResponse
{
    [JsonPropertyName("awards")]
    public IReadOnlyList<AwardRecipientDto>? Awards { get; init; }
}

public record AwardDto
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }
}

public record AwardRecipientDto
{
    [JsonPropertyName("award")]
    public AwardDto? Award { get; init; }

    [JsonPropertyName("season")]
    public string? Season { get; init; }

    [JsonPropertyName("date")]
    public DateOnly? Date { get; init; }

    [JsonPropertyName("player")]
    public PersonReferenceDto? Player { get; init; }

    [JsonPropertyName("team")]
    public TeamReferenceDto? Team { get; init; }
}

public record DraftResponse
{
    [JsonPropertyName("drafts")]
    public IReadOnlyList<DraftYearDto>? Drafts { get; init; }
}

public record DraftYearDto
{
    [JsonPropertyName("year")]
    public string? Year { get; init; }

    [JsonPropertyName("rounds")]
    public IReadOnlyList<DraftRoundDto>? Rounds { get; init; }
}

public record DraftRoundDto
{
    [JsonPropertyName("round")]
    public string? Round { get; init; }

    [JsonPropertyName("picks")]
    public IReadOnlyList<DraftPickDto>? Picks { get; init; }
}

public record DraftPickDto
{
    [JsonPropertyName("pickNumber")]
    public int? PickNumber { get; init; }

    [JsonPropertyName("roundPickNumber")]
    public int? RoundPickNumber { get; init; }

    [JsonPropertyName("rank")]
    public int? Rank { get; init; }

    [JsonPropertyName("pickValue")]
    public string? PickValue { get; init; }

    [JsonPropertyName("signingBonus")]
    public string? SigningBonus { get; init; }

    [JsonPropertyName("home")]
    public JsonElement? Home { get; init; }

    [JsonPropertyName("school")]
    public JsonElement? School { get; init; }

    [JsonPropertyName("team")]
    public TeamReferenceDto? Team { get; init; }

    [JsonPropertyName("person")]
    public PersonReferenceDto? Person { get; init; }
}

public record TransactionsResponse
{
    [JsonPropertyName("transactions")]
    public IReadOnlyList<TransactionDto>? Transactions { get; init; }
}

public record TransactionDto
{
    [JsonPropertyName("id")]
    public int? Id { get; init; }

    [JsonPropertyName("person")]
    public PersonReferenceDto? Person { get; init; }

    [JsonPropertyName("toTeam")]
    public TeamReferenceDto? ToTeam { get; init; }

    [JsonPropertyName("fromTeam")]
    public TeamReferenceDto? FromTeam { get; init; }

    [JsonPropertyName("typeCode")]
    public string? TypeCode { get; init; }

    [JsonPropertyName("typeDesc")]
    public string? TypeDesc { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("date")]
    public DateOnly? Date { get; init; }

    [JsonPropertyName("effectiveDate")]
    public DateOnly? EffectiveDate { get; init; }
}
