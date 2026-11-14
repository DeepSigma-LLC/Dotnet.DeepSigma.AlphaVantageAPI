namespace DeepSigma.AlphaVantageAPI.APIs.Fundamentals.Models;

public sealed class AVSharesOutstandingResponse
{
    public string Symbol { get; set; } = "";
    public string Status { get; set; } = "";
    public List<AVSharesOutstandingData> Data { get; set; } = [];
}
