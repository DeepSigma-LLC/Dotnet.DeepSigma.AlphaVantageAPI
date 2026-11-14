using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.APIs.Fundamentals.Models;

/// <summary>
/// The class represents insider transaction data from the Alpha Vantage API.
/// </summary>
[JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
public class AVInsiderTransactionData
{
    /// <summary>
    /// The date time of the transaction.
    /// </summary>
    [JsonPropertyName("transaction_date")]
    public DateOnly TransactionDate { get; set; }

    /// <summary>
    /// The stock ticker symbol associated with the transaction.
    /// </summary>
    [JsonPropertyName("ticker")]
    public string Ticker { get; set; } = string.Empty;

    /// <summary>
    /// The name of the executive involved in the transaction.
    /// </summary>
    [JsonPropertyName("executive")]
    public string Executive { get; set; } = string.Empty;

    /// <summary>
    /// The title of the executive involved in the transaction.
    /// </summary>
    [JsonPropertyName("executive_title")]
    public string ExecutiveTitle { get; set; } = string.Empty;

    /// <summary>
    /// The security type involved in the transaction (e.g., common stock, options).
    /// </summary>
    [JsonPropertyName("security_type")]
    public string SecurityType { get; set; } = string.Empty;

    /// <summary>
    /// The nature of the transaction, either an acquisition or disposal of shares.
    /// </summary>
    [JsonPropertyName("acquisition_or_disposal")]
    public string AcquisitionOrDisposal { get; set; } = string.Empty;

    /// <summary>
    /// The number of shares involved in the transaction.
    /// </summary>
    [JsonPropertyName("shares")]
    public double Shares { get; set; }

    /// <summary>
    /// The share price at which the transaction occurred.
    /// </summary>
    [JsonPropertyName("share_price")]
    public double SharePrice { get; set; }

}
