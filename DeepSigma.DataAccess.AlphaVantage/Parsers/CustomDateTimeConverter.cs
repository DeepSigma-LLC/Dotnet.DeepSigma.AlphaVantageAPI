
using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace DeepSigma.AlphaVantageAPI.Parsers;

/// <summary>
/// A custom JSON converter for DateTime that handles the specific format used by the Alpha Vantage API.
/// </summary>
public class CustomDateTimeConverter : JsonConverter<DateTime>
{
    private const string Format = "yyyy-MM-dd HH:mm:ss.fff";

    /// <inheritdoc/>
    public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? dateString = reader.GetString();

        if (string.IsNullOrWhiteSpace(dateString))
        {
            throw new JsonException("Timestamp value was null or empty.");
        }

        // ParseExact handles the space separator cleanly
        if (DateTime.TryParseExact(dateString, Format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
        {
            return result;
        }

        // Fallback to standard parsing if the milliseconds vary or a 'T' is occasionally present
        if (DateTime.TryParse(dateString, CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
        {
            return result;
        }

        throw new JsonException($"Unable to parse \"{dateString}\" as a DateTime.");
    }

    ///Writes the date and time as a JSON string using the configured format and invariant culture.The writer to which the JSON string is written.The date and time to write.The options used for serialization.
    public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString(Format, CultureInfo.InvariantCulture));
    }
}
