using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.DataModels;

/// <summary>
/// The class represents a dividend record from the Alpha Vantage API.
/// </summary>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public class AVDividendRecord
{
    /// <summary>
    /// The ex-dividend date of the dividend record.
    /// </summary>
    [JsonPropertyName("ex_dividend_date")]
    public DateOnly ExDividendDate { get; set; }

    /// <summary>
    /// The declaration date of the dividend record.
    /// </summary>
    [JsonPropertyName("declaration_date")]
    public DateOnly DeclarationDate { get; set; }

    /// <summary>
    /// The record date of the dividend record.
    /// </summary>
    [JsonPropertyName("record_date")]
    public DateOnly RecordDate { get; set; }

    /// <summary>
    /// The payment date of the dividend record.
    /// </summary>
    [JsonPropertyName("payment_date")]
    public DateOnly PaymentDate { get; set; }

    /// <summary>
    /// The amount of the dividend.
    /// </summary>
    [JsonPropertyName("amount")]
    public decimal Amount { get; set; }
}
