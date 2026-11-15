# DeepSigma.AlphaVantageAPI

A .NET client library for working with the [Alpha Vantage](https://www.alphavantage.co/) API in C#.

The client groups supported Alpha Vantage endpoints behind an `AlphaVantageAPI` facade. Endpoint modules expose asynchronous request methods, and many also provide static JSON/CSV parsers so saved responses can be read without making HTTP requests. The repository includes xUnit tests and response fixtures.

## Supported API areas

The facade exposes the following modules:

- `Utilities`: symbol search, market status, top gainers/losers/most active, historical news, ETF profiles and holdings, listing status, earnings and IPO calendars, institutional holdings, congressional trades, and politician metadata.
- `StockData`: intraday, daily, weekly, and monthly time series; bulk real-time quotes; bulk bid/ask prices.
- `OptionData`: real-time and historical option chains, put/call ratios, and volume-to-open-interest ratios.
- `CommodityData`: WTI, Brent, natural gas, copper, aluminum, wheat, corn, cotton, sugar, coffee, and the global commodity index.
- `FundamentalData`: company overview and logo, insider transactions, earnings transcripts/history/estimates, dividends, stock splits, shares outstanding, income statements, balance sheets, and cash flows.
- `FXData`: exchange-rate quotes and intraday, daily, weekly, and monthly FX time series.
- `CryptoData`: exchange-rate quotes and intraday, daily, weekly, and monthly cryptocurrency time series.
- `EconomicData`: real GDP, real GDP per capita, CPI, inflation, retail sales, durable goods orders, non-farm payrolls, and unemployment.
- `FixedIncomeData`: U.S. Treasury yields and the federal funds rate.
- `IndexData`: index catalog and index time series.

## Highlights

- Unified entry point through `AlphaVantageAPI`
- Async request methods with cancellation-token support
- Strongly typed response models
- Static JSON/CSV parsing helpers for saved responses
- Configurable request timeout and optional JSON/CSV logging callbacks
- xUnit tests with sample response files for parser validation

## Target framework

The library and test project target .NET 11. Use a compatible .NET 11 SDK to build and run the project.

## Installation

### Option 1: reference the project directly

```bash
dotnet add reference path/to/DeepSigma.AlphaVantageAPI.csproj
```

### Option 2: add the NuGet package

The library project generates a NuGet package on build. Its default package ID is `DeepSigma.AlphaVantageAPI`:

```bash
dotnet add package DeepSigma.AlphaVantageAPI
```

## Getting an API key

Create an Alpha Vantage API key from the Alpha Vantage website, then pass it into the client constructor:

```csharp
using DeepSigma.AlphaVantageAPI;

var api = new AlphaVantageAPI("YOUR_ALPHA_VANTAGE_API_KEY");
```

Pass an `ApiOptions` instance to configure the request timeout and raw response callbacks. JSON and CSV callbacks are invoked for their corresponding response formats:

```csharp
using DeepSigma.AlphaVantageAPI;

var options = new ApiOptions(
    APIKey: "YOUR_ALPHA_VANTAGE_API_KEY",
    TimeoutSeconds: 30,
    JSONLogger: json => Console.WriteLine(json),
    CSVLogger: csv => Console.WriteLine(csv));

var api = new AlphaVantageAPI(options.APIKey, options);
```

## Quick start

### Daily stock data

```csharp
using DeepSigma.AlphaVantageAPI;

var api = new AlphaVantageAPI("YOUR_ALPHA_VANTAGE_API_KEY");

var daily = await api.StockData.GetDailyTimeSeriesData("MSFT");

if (daily is not null)
{
    Console.WriteLine($"Bars returned: {daily.Data.Count}");
}
```

### Intraday stock data

```csharp
using DeepSigma.AlphaVantageAPI;
using DeepSigma.AlphaVantageAPI.Enums;

var api = new AlphaVantageAPI("YOUR_ALPHA_VANTAGE_API_KEY");

var intraday = await api.StockData.GetIntradayTimeSeriesData(
    symbol: "AAPL",
    interval: TimeSeriesIntradayInterval.Fifteen,
    output_size: OutputSize.Full,
    extended_hours: true
);
```

### FX quote

```csharp
var api = new AlphaVantageAPI("YOUR_ALPHA_VANTAGE_API_KEY");

var quote = await api.FXData.GetExchangeRate("USD", "EUR");

if (quote is not null)
{
    Console.WriteLine(quote.Quote.ExchangeRate);
}
```

### Crypto time series

```csharp
var api = new AlphaVantageAPI("YOUR_ALPHA_VANTAGE_API_KEY");

var btc = await api.CryptoData.GetExchangeRatesDaily("BTC", "USD");

if (btc is not null)
{
    Console.WriteLine($"Bars returned: {btc.Data.Count}");
}
```

### Company fundamentals

```csharp
var api = new AlphaVantageAPI("YOUR_ALPHA_VANTAGE_API_KEY");

var overview = await api.FundamentalData.GetCompanyOverview("MSFT");

if (overview is not null)
{
    Console.WriteLine(overview.Description);
}
```

### Options chain

```csharp
var api = new AlphaVantageAPI("YOUR_ALPHA_VANTAGE_API_KEY");

var chain = await api.OptionData.GetRealTimeOptionData("AAPL");

if (chain is not null)
{
    Console.WriteLine($"Contracts returned: {chain.Data.Count}");
}
```

### Economic data

```csharp
using DeepSigma.AlphaVantageAPI.Enums;

var api = new AlphaVantageAPI("YOUR_ALPHA_VANTAGE_API_KEY");

var cpi = await api.EconomicData.GetCPI(TimeSeriesInterval.Monthly);

if (cpi is not null)
{
    Console.WriteLine($"Data points returned: {cpi.Data.Count}");
}
```

### Index catalog and time series

```csharp
var api = new AlphaVantageAPI("YOUR_ALPHA_VANTAGE_API_KEY");

var catalog = await api.IndexData.GetIndexCatalog();
var indexData = await api.IndexData.GetIndexData("SPX");

if (catalog is not null && catalog.TryGetValue("SPX", out var indexName))
{
    Console.WriteLine(indexName);
}

if (indexData is not null)
{
    Console.WriteLine($"Index bars returned: {indexData.Data.Count}");
}
```

### Listings, earnings calendar, and IPO calendar

```csharp
using DeepSigma.AlphaVantageAPI.Enums;

var api = new AlphaVantageAPI("YOUR_ALPHA_VANTAGE_API_KEY");

var activeListings = await api.Utilities.GetAllActiveListings();
var earnings = await api.Utilities.GetEarningsCalandar("MSFT", EarningsHorizon.ThreeMonth);
var ipoCalendar = await api.Utilities.GetIPOCalandar();
```

## Working with saved responses

One of the strongest parts of this repository is that the parsers are usable independently of live API calls. This is especially helpful for:

- unit tests
- offline development
- replaying cached API responses
- validating schema changes

### Parse JSON without making a request

```csharp
using DeepSigma.AlphaVantageAPI.APIs.Fundamentals;

string json = File.ReadAllText("AVCompanyOverview.json");

var overview = FundamentalData.GetCompanyOverviewFromJson(json);

if (overview is not null)
{
    Console.WriteLine(overview.Name);
}
```

### Parse CSV utility responses

```csharp
using DeepSigma.AlphaVantageAPI.APIs.Utilities;

string csv = File.ReadAllText("earnings_calendar.csv");

var rows = UtilitiesData.GetEarningsFromCSV(csv);

Console.WriteLine(rows.Count);
```

## API surface at a glance

### Core client

```csharp
var api = new AlphaVantageAPI("YOUR_ALPHA_VANTAGE_API_KEY");

api.Utilities
api.StockData
api.OptionData
api.CommodityData
api.FundamentalData
api.FXData
api.CryptoData
api.EconomicData
api.FixedIncomeData
api.IndexData
```

### Selected methods

```csharp
// Utilities
await api.Utilities.GetTickerSearch("microsoft");
await api.Utilities.GetGlobalMarketStatus();
await api.Utilities.GetTopGainersAndLosers();
await api.Utilities.GetETFProfileAndHoldings("SPY");

// Stocks
await api.StockData.GetIntradayTimeSeriesData("MSFT");
await api.StockData.GetDailyTimeSeriesData("MSFT");
await api.StockData.GetBulkRealTimeQuoteData(new[] { "MSFT", "AAPL", "NVDA" });
await api.StockData.GetBulkRealTimeBidAskPrice(new[] { "MSFT", "AAPL" });

// Fundamentals
await api.FundamentalData.GetCompanyOverview("MSFT");
await api.FundamentalData.GetBalanceSheet("MSFT");
await api.FundamentalData.GetCashFlow("MSFT");
await api.FundamentalData.GetEarningsTranscript("MSFT", 2025, 1);

// Macro / rates / indices
await api.EconomicData.GetInflation();
await api.FixedIncomeData.GetUSTreasuryYield(FixedIncomeMaturities.TenYear);
await api.FixedIncomeData.GetFedFunds();
await api.IndexData.GetIndexCatalog();
await api.IndexData.GetIndexData("SPX");
```

## Running tests

The repository includes the `DeepSigma.DataAccess.AlphaVantage.Tests` xUnit test project and JSON/CSV fixtures under its `TestData` directory. Run it from the repository root with:

```bash
dotnet test DeepSigma.DataAccess.AlphaVantage.Tests/DeepSigma.AlphaVantageAPI.Tests.csproj
```

The tests validate response parsing against stored samples; most do not require live Alpha Vantage requests.

## Project structure

```text
.
├── DeepSigma.DataAccess.AlphaVantage
│   ├── AlphaVantageAPI.cs
│   ├── ApiOptions.cs
│   ├── APIs/
│   │   ├── Commodities/
│   │   ├── Crypto/
│   │   ├── Economics/
│   │   ├── Fixed Income/
│   │   ├── Fundamentals/
│   │   ├── FX/
│   │   ├── Index/
│   │   ├── Option/
│   │   ├── Stock/
│   │   └── Utilities/
│   ├── Enums/
│   ├── Models/
│   └── Parsers/
└── DeepSigma.DataAccess.AlphaVantage.Tests
    ├── Tests/
    └── TestData/
```

## Notes and caveats

- Alpha Vantage rate limits still apply.
- Some endpoint names in the code mirror Alpha Vantage naming very closely, including a few existing spelling inconsistencies such as `GetHistroicalNews`, `GetEarningsCalandar`, and `GetIPOCalandar`.
- The project depends on `DeepSigma.DataAccess.Web` for HTTP and serialization utilities.
- Static parser methods belong to the relevant API module (for example, `FundamentalData.GetCompanyOverviewFromJson`).

## Why this repo is useful

This repository is more than a thin HTTP wrapper. It already includes:

- typed models for a wide span of Alpha Vantage endpoints
- a single facade for discoverability
- reusable parsers
- test fixtures that make regression testing straightforward

That combination makes it useful both for application developers and for teams that want deterministic tests around market-data response parsing.

## License

No license file was included in the provided repository snapshot. Add a `LICENSE` file if you want consumers to know the terms of use clearly.
