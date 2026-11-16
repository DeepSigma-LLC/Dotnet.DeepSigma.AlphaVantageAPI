using System.Text.Json;
using DeepSigma.DataAccess.Web;

namespace DeepSigma.AlphaVantageAPI;

/// <summary>
/// Alpha Vantage's convention for a refusal: an HTTP 200 whose JSON is an object with a <c>Note</c> (an older rate-limit
/// notice), an <c>Error Message</c> (a bad call) or an <c>Information</c> (the current rate-limit and premium notice)
/// instead of data. Every JSON call of this package is checked before it is parsed, so such an answer throws instead of
/// parsing to an empty result. Moved here from DeepSigma.DataAccess.Web, where it was <c>JsonResponseGuards.AlphaVantage</c>.
/// </summary>
public static class AlphaVantageResponseGuard
{
    /// <summary>The check as a <see cref="JsonResponseGuard"/>, for <see cref="Serializer.LoadFromJson{T}"/> or an
    /// <see cref="HttpApi"/>.</summary>
    public static JsonResponseGuard Guard { get; } = static root =>
    {
        if (root.ValueKind != JsonValueKind.Object) return;
        if (root.TryGetProperty("Error Message", out var error)) throw new InvalidOperationException($"Alpha Vantage error: {Text(error)}");
        if (root.TryGetProperty("Note", out var note)) throw new InvalidOperationException($"Alpha Vantage note: {Text(note)}");
        if (root.TryGetProperty("Information", out var information))
            throw new InvalidOperationException($"Alpha Vantage information: {Text(information)}");
    };

    /// <summary>Checks a JSON answer; throws <see cref="InvalidOperationException"/> when it is a refusal. Text that is not
    /// JSON is left to the parser.</summary>
    public static void Check(string json)
    {
        ArgumentNullException.ThrowIfNull(json);
        JsonDocument document;
        try
        {
            document = JsonDocument.Parse(json);
        }
        catch (JsonException)
        {
            return;
        }
        using (document) Guard(document.RootElement);
    }

    private static string Text(JsonElement value) => value.ValueKind == JsonValueKind.String ? value.GetString() ?? "" : value.GetRawText();
}
