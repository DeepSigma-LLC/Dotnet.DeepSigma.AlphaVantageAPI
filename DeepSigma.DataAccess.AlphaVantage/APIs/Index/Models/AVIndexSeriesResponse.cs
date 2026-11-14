namespace DeepSigma.AlphaVantageAPI.APIs.Index.Models;

public class AVIndexSeriesResponse<T>
{
    public string Symbol { get; set; } = "";
    public string Name { get; set; } = "";
    public string Interval { get; set; } = "";
    public List<T> Data { get; set; } = [];
}
