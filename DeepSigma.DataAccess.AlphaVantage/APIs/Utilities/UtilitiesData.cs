using DeepSigma.AlphaVantageAPI.APIs.Utilities.Models;
using DeepSigma.AlphaVantageAPI.Models;
using DeepSigma.AlphaVantageAPI.Enums;
using DeepSigma.Core.Extensions;
using DeepSigma.DataAccess.Web;
using System.Dynamic;

namespace DeepSigma.AlphaVantageAPI.APIs.Utilities;

/// <summary>
/// This class contains various utility functions provided by Alpha Vantage, such as ticker search, market status, top gainers/losers, news sentiment, ETF profiles, and listings.
/// </summary>
public class UtilitiesData(HttpClient client, ApiOptions options) : AbstractDataAPI(client, options)
{
    /// <summary>
    /// The Search Endpoint returns the best-matching symbols and market information based on keywords of your choice. 
    /// The search results also contain match scores that provide you with the full flexibility to develop your own search and filtering logic.
    /// </summary>
    /// <param name="keyword"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVTickerSearchResponse?> GetTickerSearch(string keyword, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=SYMBOL_SEARCH&keywords={keyword}&apikey={Options.APIKey}";
        AVTickerSearchResponse? results = await Utilities.GetAPIData(url, GetTickerSearchFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Ticker Search.
    /// The Search Endpoint returns the best-matching symbols and market information based on keywords of your choice. 
    /// The search results also contain match scores that provide you with the full flexibility to develop your own search and filtering logic.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVTickerSearchResponse? GetTickerSearchFromJson(string json) => Serializer.LoadFromJson<AVTickerSearchResponse>(json);

    /// <summary>
    /// This endpoint returns the current market status (open vs. closed) of major trading venues for equities, forex, and cryptocurrencies around the world.
    /// </summary>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVMarketClosureResponse?> GetGlobalMarketStatus(CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=MARKET_STATUS&apikey={Options.APIKey}";
        AVMarketClosureResponse? results = await Utilities.GetAPIData(url, GetGlobalMarketStatusFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Global Market Status.
    /// This endpoint returns the current market status (open vs. closed) of major trading venues for equities, forex, and cryptocurrencies around the world.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVMarketClosureResponse? GetGlobalMarketStatusFromJson(string json) => Serializer.LoadFromJson<AVMarketClosureResponse>(json);

    /// <summary>
    /// This endpoint returns the top 20 gainers, losers, and the most active traded tickers in the US market.
    /// </summary>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVMoverResponse?> GetTopGainersAndLosers(CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=TOP_GAINERS_LOSERS&apikey={Options.APIKey}";
        AVMoverResponse? results = await Utilities.GetAPIData(url, GetTopGainersAndLosersFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for Top Gainers and Losers.
    /// This endpoint returns the top 20 gainers, losers, and the most active traded tickers in the US market.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVMoverResponse? GetTopGainersAndLosersFromJson(string json) => Serializer.LoadFromJson<AVMoverResponse>(json);

    /// <summary>
    /// This API returns live and historical market news and sentiment data from a large and growing selection of premier news outlets around the world, 
    /// covering stocks, cryptocurrencies, forex, and a wide range of topics such as fiscal policy, mergers and acquisitions, IPOs, etc. 
    /// This API, combined with our core stock API, fundamental data, and technical indicator APIs, can provide you with a 360-degree view of the financial market and the broader economy.
    /// </summary>
    /// <param name="symbols"></param>
    /// <param name="StartDate"></param>
    /// <param name="EndDate"></param>
    /// <param name="sort_type"></param>
    /// <param name="topics"></param>
    /// <param name="limit"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<dynamic?> GetHistroicalNews(string[] symbols, DateTime? StartDate = null, DateTime? EndDate = null, SortType sort_type = SortType.Latest, NewsTopicTypes[]? topics = null, int limit = 1000, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=NEWS_SENTIMENT&tickers={string.Join(",", symbols)}&limit={limit}&sort=LATEST&apikey={Options.APIKey}";
        
        if(StartDate.HasValue)
        {
            url += $"&time_from={StartDate.Value.ToUniversalTime().ToString()}";
        }

        if(EndDate.HasValue)
        {
            url += $"&time_to={EndDate.Value.ToUniversalTime().ToString()}";
        }

        if(topics is not null && topics.Length > 0)
        {
            url += $"&topics={string.Join(",", topics.Select(t => t.ToDescriptionString()))}";
        }

        var results = await HttpApi.GetDataFromUrlAsync<dynamic>(url, Options.TimeoutSeconds, Options.JSONLogger, ct);       
        return results;
    }


    /// <summary>
    /// This API returns key ETF metrics (e.g., net assets, expense ratio, and turnover), along with the corresponding ETF holdings / constituents with allocation by asset types and sectors.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVETFProfileResponse?> GetETFProfileAndHoldings(string symbol, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=ETF_PROFILE&symbol={symbol}&apikey={Options.APIKey}";
        AVETFProfileResponse? results = await Utilities.GetAPIData(url, GetETFProfileAndHoldingsFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parses the JSON response returned by the Alpha Vantage API for ETF Profile and Holdings.
    /// This API returns key ETF metrics (e.g., net assets, expense ratio, and turnover), along with the corresponding ETF holdings / constituents with allocation by asset types and sectors.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVETFProfileResponse? GetETFProfileAndHoldingsFromJson(string json) => Serializer.LoadFromJson<AVETFProfileResponse>(json);
 

    /// <summary>
    /// This API returns a list of active or delisted US stocks and ETFs, either as of the latest trading day. 
    /// The endpoint is positioned to facilitate equity research on asset lifecycle and survivorship.
    /// </summary>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<List<AVListingStatusCSVData>?> GetAllActiveListings(CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=LISTING_STATUS&apikey={Options.APIKey}";
        List<AVListingStatusCSVData>? results = await Utilities.GetAPIDataCSVFormat(url, GetListingsFromCSV, Options.TimeoutSeconds, ct, Options.CSVLogger);
        return results;
    }

    /// <summary>
    /// This API returns a list of active or delisted US stocks and ETFs, either as of the latest trading day or at a specific time in history. 
    /// The endpoint is positioned to facilitate equity research on asset lifecycle and survivorship.
    /// </summary>
    /// <param name="date"></param>
    /// <param name="listing_status"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<List<AVListingStatusCSVData>?> GetAllListings(DateOnly date, ListingStatus listing_status, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=LISTING_STATUS&date={date.ToString("D")}&state={listing_status.ToDescriptionString()}&apikey={Options.APIKey}";
        List<AVListingStatusCSVData>? results = await Utilities.GetAPIDataCSVFormat(url, GetListingsFromCSV, Options.TimeoutSeconds, ct, Options.CSVLogger);
        return results;
    }


    /// <summary>
    /// Parses the CSV response returned by the Alpha Vantage API for Listing Status.
    /// This API returns a list of active or delisted US stocks and ETFs, either as of the latest trading day. 
    /// The endpoint is positioned to facilitate equity research on asset lifecycle and survivorship.
    /// </summary>
    /// <param name="csv"></param>
    /// <returns></returns>
    public static List<AVListingStatusCSVData> GetListingsFromCSV(string csv)
    {
        csv = csv.Replace(",null,", ",,");
        List<AVListingStatusCSVData>? results = Serializer.LoadFromCsv<AVListingStatusCSVData>(csv);
        return results ?? [];
    }

    /// <summary>
    /// This API returns a list of company earnings expected in the next 3, 6, or 12 months.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="horizon"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<List<AVEarningsCalandarCSVData>?> GetEarningsCalandar(string symbol, EarningsHorizon horizon, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=EARNINGS_CALENDAR&symbol={symbol}&horizon={horizon.ToDescriptionString()}&&apikey={Options.APIKey}";
        List<AVEarningsCalandarCSVData>? results = await Utilities.GetAPIDataCSVFormat(url, GetEarningsFromCSV, Options.TimeoutSeconds, ct, Options.CSVLogger);
        return results;
    }

    /// <summary>
    /// Parses the CSV response returned by the Alpha Vantage API for Earnings Calendar.
    /// This API returns a list of company earnings expected in the next 3, 6, or 12 months.
    /// </summary>
    /// <param name="csv"></param>
    /// <returns></returns>
    public static List<AVEarningsCalandarCSVData>? GetEarningsFromCSV(string csv) => Serializer.LoadFromCsv<AVEarningsCalandarCSVData>(csv);

    /// <summary>
    /// This API returns a list of IPOs expected in the next 3 months.
    /// </summary>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<List<AVIpoCalandarCSVData>?> GetIPOCalandar(CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=IPO_CALENDAR&apikey={Options.APIKey}";
        List<AVIpoCalandarCSVData>? results = await Utilities.GetAPIDataCSVFormat(url, GetIPOCalandarFromCSV, Options.TimeoutSeconds, ct, Options.CSVLogger);
        return results;
    }

    /// <summary>
    /// Parses the CSV response returned by the Alpha Vantage API for IPO Calendar.
    /// This API returns a list of IPOs expected in the next 3 months.
    /// </summary>
    /// <param name="csv"></param>
    /// <returns></returns>
    public static List<AVIpoCalandarCSVData>? GetIPOCalandarFromCSV(string csv) => Serializer.LoadFromCsv<AVIpoCalandarCSVData>(csv);


    /// <summary>
    /// This API returns the institutional ownership and holdings information for an equity of interest.
    /// </summary>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVInstitutionalHoldingResponse?> GetInstitutionalHoldings(CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=INSTITUTIONAL_HOLDINGS&apikey={Options.APIKey}";
        AVInstitutionalHoldingResponse? results = await Utilities.GetAPIData(url, GetInstitutionalHoldingsFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }


    /// <summary>
    /// Parse the JSON response returned by the Alpha Vantage API for Institutional Holdings.
    /// This API returns the institutional ownership and holdings information for an equity of interest.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVInstitutionalHoldingResponse? GetInstitutionalHoldingsFromJson(string json) => Serializer.LoadFromJson<AVInstitutionalHoldingResponse>(json);


    /// <summary>
    /// This API returns the latest and historical stock trades disclosed by US congressional representatives.
    /// </summary>
    /// <param name="symbol"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVCongressTradesResponse?> GetCongressTrades(string symbol, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=CONGRESS_TRADES&symbol={symbol}&apikey={Options.APIKey}";
        AVCongressTradesResponse? results = await Utilities.GetAPIData(url, GetCongressTradesFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// This API returns the latest and historical stock trades disclosed by US congressional representatives.
    /// </summary>
    /// <param name="bioguide_id"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVCongressTradesResponse?> GetCongressTradesByBioguideId(string bioguide_id, CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=CONGRESS_TRADES&bioguide_id={bioguide_id}&apikey={Options.APIKey}";
        AVCongressTradesResponse? results = await Utilities.GetAPIData(url, GetCongressTradesFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parse the JSON response returned by the Alpha Vantage API for Congress Trades.
    /// This API returns the latest and historical stock trades disclosed by US congressional representatives.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVCongressTradesResponse? GetCongressTradesFromJson(string json) => Serializer.LoadFromJson<AVCongressTradesResponse>(json);


    /// <summary>
    /// This API returns the key metadata for US congressional representatives, such as bioguide_id, district, time in service, etc.
    /// </summary>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<AVPoliticianMetaDataResponse?> GetPoliticianMetaData(CancellationToken ct = default)
    {
        string url = $"https://www.alphavantage.co/query?function=POLITICIAN_METADATA&apikey={Options.APIKey}";
        AVPoliticianMetaDataResponse? results = await Utilities.GetAPIData(url, GetPoliticianMetaDataFromJson, Options.TimeoutSeconds, ct, Options.JSONLogger);
        return results;
    }

    /// <summary>
    /// Parse the JSON response returned by the Alpha Vantage API for Politician Meta Data.
    /// This API returns the key metadata for US congressional representatives, such as bioguide_id, district, time in service, etc.
    /// </summary>
    /// <param name="json"></param>
    /// <returns></returns>
    public static AVPoliticianMetaDataResponse? GetPoliticianMetaDataFromJson(string json) => Serializer.LoadFromJson<AVPoliticianMetaDataResponse>(json);
}
