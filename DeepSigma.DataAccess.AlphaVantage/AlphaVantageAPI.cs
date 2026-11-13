
namespace DeepSigma.AlphaVantageAPI;

/// <summary>
/// Alpha Vantage API Client.
/// </summary>
public class AlphaVantageAPI
{
    private HttpClient client { get; }
    private ApiOptions Options { get; }

    /// <summary>
    ///Initializes a new instance of the <see cref="AlphaVantageAPI"/> class.
    /// </summary>
    /// <param name="api_key">The API key used to authenticate requests to Alpha Vantage.</param>
    /// <param name="options">Optional API options.</param>
    public AlphaVantageAPI(string api_key, ApiOptions? options = null)
    {
        client = new HttpClient();
        Options = options ?? new ApiOptions(api_key, 15, null, null);
        Utilities = new UtilitiesData(client, Options);
        StockData = new StockData(client, Options);

        OptionData = new OptionData(client, Options);
        CommodityData = new CommodityData(client, Options);
        FundamentalData = new FundamentalData(client, Options);
        FXData = new FXData(client, Options);
        CryptoData = new CryptoData(client, Options);
        EconomicData = new EconomicData(client, Options);
        FixedIncomeData = new FixedIncomeData(client, Options);

    }

    /// <summary>
    /// Utilities for Alpha Vantage API.
    /// </summary>
    public UtilitiesData Utilities { get; }
    /// <summary>
    /// Stock data related APIs.
    /// </summary>
    public StockData StockData { get; }
    /// <summary>
    /// Option data related APIs.
    /// </summary>
    public OptionData OptionData { get; } 
    /// <summary>
    /// Commodity data related APIs.
    /// </summary>
    public CommodityData CommodityData { get; }
    /// <summary>
    /// Fundamental data related APIs.
    /// </summary>
    public FundamentalData FundamentalData { get; }
    /// <summary>
    /// Forex data related APIs.
    /// </summary>
    public FXData FXData { get; }
    /// <summary>
    /// Cryptocurrency data related APIs.
    /// </summary>
    public CryptoData CryptoData { get; }
    /// <summary>
    /// Economic data related APIs.
    /// </summary>
    public EconomicData EconomicData { get; }
    /// <summary>
    /// Fixed income data related APIs.
    /// </summary>
    public FixedIncomeData FixedIncomeData { get; }
}
