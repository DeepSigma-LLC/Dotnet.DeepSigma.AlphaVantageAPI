using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.DataModels;

public sealed class AVVolumeToOpenInterestRatioData
{
    public string ContractID { get; set; } = "";
    public string Symbol { get; set; } = "";
    public DateTime Expiration { get; set; }
    public decimal Strike { get; set; }
    public string Type { get; set; } = "";
    public DateTime Date { get; set; }

    [JsonPropertyName("volume_open_interest_ratio")]
    public decimal? VolumeOpenInterestRatio { get; set; }

}