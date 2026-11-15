using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Utilities.Models;

public sealed class AVCongressTrade
{
    public string? Chamber { get; set; }

    public string? Politician { get; set; }

    [JsonPropertyName("bioguide_id")]
    public string? BioguideId { get; set; }


    public string? PoliticianCanonical { get; set; }

    public string? Party { get; set; }

    public string? State { get; set; }

    [JsonPropertyName("state_district")]
    public string? StateDistrict { get; set; }


    public string? Symbol { get; set; }

    [JsonPropertyName("ticker_reported")]
    public string? TickerReported { get; set; }
    [JsonPropertyName("ticker_source")]
    public string? TickerSource { get; set; }

    [JsonPropertyName("asset_name")]
    public string? AssetName { get; set; }

    [JsonPropertyName("asset_type_code")]
    public string? AssetTypeCode { get; set; }

    [JsonPropertyName("transaction_type")]
    public string? TransactionType { get; set; }
    
    [JsonPropertyName("transaction_date")]
    public DateTime? TransactionDate { get; set; }


    [JsonPropertyName("notification_date")]
    public DateTime? NotificationDate { get; set; }

    [JsonPropertyName("amount_min")]
    public decimal? AmountMin { get; set; }

    [JsonPropertyName("amount_max")]
    public decimal? AmountMax { get; set; }

    [JsonPropertyName("owner_code")]
    public string? OwnerCode { get; set; }

    [JsonPropertyName("filing_status")]
    public string? FilingStatus { get; set; }

    [JsonPropertyName("filed_date")]
    public DateTime? FiledDate { get; set; }

    [JsonPropertyName("extraction_method")]
    public string? ExtractionMethod { get; set; }

    [JsonPropertyName("extraction_confidence")]
    public string? ExtractionConfidence { get; set; }

    [JsonPropertyName("extraction_flags")]
    public List<string> ExtractionFlags { get; set; } = [];

    [JsonPropertyName("source_page")]
    public int? SourcePage { get; set; }

    [JsonPropertyName("source_row")]
    public int? SourceRow { get; set; }

    [JsonPropertyName("extraction_artifact_sha256")]
    public string? ExtractionArtifactSha256 { get; set; }

}