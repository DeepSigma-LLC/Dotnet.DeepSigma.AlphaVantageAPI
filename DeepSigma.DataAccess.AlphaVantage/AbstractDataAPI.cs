
using DeepSigma.DataAccess.Web;

namespace DeepSigma.AlphaVantageAPI;

/// <summary>
/// Abstract base class for data API classes that interact with the Alpha Vantage API.
/// </summary>
/// <param name="client"></param>
/// <param name="options"></param>
public abstract class AbstractDataAPI(HttpClient client, ApiOptions options)
{
    /// <summary>
    ///Gets or sets the API options.    
    /// </summary>
    protected ApiOptions Options { get; init; } = options;

    /// <summary>
    ///Gets or sets the Alpha Vantage API utilities.    
    /// </summary>
    internal AlphaVantageAPIUtilities Utilities { get; init; } = new AlphaVantageAPIUtilities(client);

    /// <summary>
    ///Gets or sets the HTTP API used to send requests to the Alpha Vantage service.    
    /// </summary>
    protected HttpApi HttpApi { get; init; } = new HttpApi(client, responseGuard: AlphaVantageResponseGuard.Guard);
}
