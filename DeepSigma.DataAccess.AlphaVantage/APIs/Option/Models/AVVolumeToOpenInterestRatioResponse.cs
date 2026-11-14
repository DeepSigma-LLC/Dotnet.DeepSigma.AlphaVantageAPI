namespace DeepSigma.AlphaVantageAPI.APIs.Option.Models;

public sealed class AVVolumeToOpenInterestRatioResponse
{
    public string Symbol { get; set; } = "";
    public DateTime? Date { get; set; }
    public List<AVVolumeToOpenInterestRatioData> Data { get; set; } = [];
}
