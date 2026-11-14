using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Utilities.Models;

public sealed class AVInstitutionalHoldingResponse
{

    public string Symbol { get; set; } = "";

    [JsonPropertyName("total_institutional_holders")]
    public long? TotalInstitutionalHolders { get; set; }

    [JsonPropertyName("total_institutional_shares")]
    public long? TotalInstitutionalShares { get; set; }

    [JsonPropertyName("holders_with_increased_holdings")]
    public long? HoldersWithIncreasedHoldings { get; set; }

    [JsonPropertyName("shares_with_increased_holdings")]
    public long? SharesWithIncreasedHoldings { get; set; }

    [JsonPropertyName("holders_with_decreased_holdings")]
    public long? HoldersWithDecreasedHoldings { get; set; }

    [JsonPropertyName("shares_with_decreased_holdings")]
    public long? SharesWithDecreasedHoldings { get; set; }


    [JsonPropertyName("holders_with_unchanged_holdings")]
    public long? HoldersWithUnchangedHoldings { get; set; }

    [JsonPropertyName("shares_with_unchanged_holdings")]
    public long? SharesWithUnchangedHoldings { get; set; }

    [JsonPropertyName("total_institutional_ownership_percentage")]
    public string TotalInstitutionalOwnershipPercentage { get; set; } = "";

    [JsonPropertyName("holdings")]
    public List<AVInstitutionalHolding> Holdings { get; set; } = new List<AVInstitutionalHolding>();

}
