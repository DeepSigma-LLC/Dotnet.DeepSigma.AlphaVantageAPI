
using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.DataModels;

public sealed class AVCompanyLogoResponse
{
    public string Symbol { get; set; } = "";

    [JsonPropertyName("logo_url_png")]
    public string LogoUrlPng { get; set; } = "";

    [JsonPropertyName("logo_url_svg")]
    public string LogoUrlSvg { get; set; } = "";
}
