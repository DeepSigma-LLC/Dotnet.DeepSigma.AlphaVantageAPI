using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.DataModels;

/// <summary>
/// The class represents the profile response for an ETF from the Alpha Vantage API.
/// </summary>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public class AVETFProfileResponse
{
    /// <summary>
    /// The net assets of the ETF.
    /// </summary>
    [JsonPropertyName("net_assets")]
    public long NetAssets { get; set; }

    /// <summary>
    /// The net expense ratio of the ETF.
    /// </summary>
    [JsonPropertyName("net_expense_ratio")]
    public decimal NetExpenseRatio { get; set; }

    /// <summary>
    /// The portfolio turnover rate of the ETF.
    /// </summary>
    [JsonPropertyName("portfolio_turnover")]
    public decimal PortfolioTurnover { get; set; }

    /// <summary>
    /// The dividend yield of the ETF.
    /// </summary>
    [JsonPropertyName("dividend_yield")]
    public decimal DividendYield { get; set; }

    /// <summary>
    /// The inception date of the ETF.
    /// </summary>
    [JsonPropertyName("inception_date")]
    public DateOnly InceptionDate { get; set; }

    /// <summary>
    /// Indicates whether the ETF is leveraged.
    /// </summary>
    [JsonPropertyName("leveraged")]
    public string Leveraged { get; set; } = string.Empty;

    /// <summary>
    /// The sectors and their respective weights in the ETF.
    /// </summary>
    [JsonPropertyName("sectors")]
    public List<AVETFProfileSectorWeight> Sectors { get; set; } = [];

    /// <summary>
    /// The top holdings and their respective weights in the ETF.
    /// </summary>
    [JsonPropertyName("holdings")]
    public List<AVETFProfileHoldingWeight> Holdings { get; set; } = [];

}
