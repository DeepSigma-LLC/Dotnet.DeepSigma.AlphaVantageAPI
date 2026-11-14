namespace DeepSigma.AlphaVantageAPI;

/// <summary>
///Provides configuration options for API requests.
/// </summary>
/// <param name="APIKey">The API key used to authenticate requests.</param>
/// <param name="JSONLogger">An optional callback that receives JSON data for logging.</param>
/// <param name="TimeoutSeconds">The request timeout in seconds. Defaults to 15.</param>
/// <param name="CSVLogger">An optional callback that receives CSV data for logging.</param>
public record ApiOptions(string APIKey, int TimeoutSeconds = 15, Action<string>? JSONLogger = null, Action<string>? CSVLogger = null);
