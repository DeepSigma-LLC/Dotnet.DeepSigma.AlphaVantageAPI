using System.Text.Json;
using System.Text.RegularExpressions;

namespace DeepSigma.AlphaVantageAPI.Parsers;

/// <summary>
/// Base class for parsing Alpha Vantage API responses.
/// </summary>
internal abstract class AVResponseParser
{
    private static readonly Regex NumberPrefix = new(@"^\s*\d+\.\s*", RegexOptions.Compiled);

    /// <summary>
    /// Parses a JsonElement object into a dictionary of key-value pairs, where keys are cleaned and normalized (lowercase, no leading numbers or dots, underscores replaced with spaces) and values are converted to strings.
    /// </summary>
    /// <param name="json_object"></param>
    /// <returns></returns>
    private protected static Dictionary<string, string> GetResponseElements(JsonElement json_object)
    {
        Dictionary<string, string> map = new(StringComparer.OrdinalIgnoreCase);

        foreach (var p in json_object.EnumerateObject())
        {
            string key = CleanAndNormalizeKey(p.Name);
            string value = p.Value.ValueKind == JsonValueKind.String ? p.Value.GetString() ?? "" : p.Value.ToString();
            map[key] = value;
        }
        return map;
    }

    /// <summary>
    /// Tries to get the value for the first key that exists in the map and is not null or whitespace. Keys are checked in the order they are provided.
    /// </summary>
    /// <param name="map"></param>
    /// <param name="format_provider"></param>
    /// <param name="keys"></param>
    /// <returns></returns>
    private protected static T? TryGet<T>(Dictionary<string, string> map, IFormatProvider? format_provider = null, params string[] keys) where T : IParsable<T>
    {
        foreach (var k in keys)
        {
            var norm = k.ToLowerInvariant();
            if (map.TryGetValue(norm, out var v) && !string.IsNullOrWhiteSpace(v))
            {
                return T.Parse(v, format_provider);
            }
        }
        return default;
    }

    /// <summary>
    /// Cleans the key. Removes any leading number and dot (e.g. "1. "), replaces underscores with spaces, trims whitespace, and converts to lower case.
    /// </summary>
    /// <param name="k"></param>
    /// <returns></returns>
    private static string CleanAndNormalizeKey(string k)
    {
        var s = NumberPrefix.Replace(k, ""); // drop "1. "
        s = s.Replace('_', ' ').Trim();
        return s.ToLowerInvariant();         // canonical form
    }
}
