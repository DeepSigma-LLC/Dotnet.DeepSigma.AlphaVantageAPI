using System.Text.Json.Serialization;

namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    [JsonNumberHandling(JsonNumberHandling.AllowReadingFromString)]
    public sealed class AVBulkQuoteData
    {
        [JsonPropertyName("symbol")]
        public string Symbol { get; init; } = string.Empty;

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; init; }

        [JsonPropertyName("open")]
        public decimal Open { get; init; }

        [JsonPropertyName("high")]
        public decimal High { get; init; }

        [JsonPropertyName("low")]
        public decimal Low { get; init; }

        [JsonPropertyName("close")]
        public decimal Close { get; init; }

        [JsonPropertyName("adjusted close")]
        public decimal AdjustedClose { get; init; }

        [JsonPropertyName("volume")]
        public long Volume { get; init; }

        [JsonPropertyName("previous_close")]
        public decimal PreviousClose { get; init; }

        [JsonPropertyName("change")]
        public decimal Change { get; init; }

        [JsonPropertyName("change_percent")]
        public decimal ChangePercent { get; init; }

        [JsonPropertyName("extended_hours_quote")]
        public decimal ExtendedHoursQuote { get; init; }

        [JsonPropertyName("extended_hours_change")]
        public decimal ExtendedHoursChange { get; init; }

        [JsonPropertyName("extended_hours_change_percent")]
        public decimal ExtendedHoursChangePercent { get; init; }
    }
}
