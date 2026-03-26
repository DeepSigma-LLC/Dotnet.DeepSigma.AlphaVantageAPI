# DeepSigma.AlphaVantageAPI

A .NET client library for working with the [Alpha Vantage](https://www.alphavantage.co/) API in C#.

This project wraps multiple Alpha Vantage endpoints behind a single `AlphaVantageAPI` facade and also provides static JSON/CSV parsing helpers that let you deserialize saved responses without making live HTTP requests. The repository includes xUnit tests plus fixture data covering the supported response formats.

## What this library covers

The client is organized into focused modules exposed from `AlphaVantageAPI`:

- `Utilities`
  - Symbol search
  - Global market status
  - Top gainers / losers / most active
  - Historical news
  - ETF profile and holdings
  - Listing status
  - Earnings calendar
  - IPO calendar
- `StockData`
  - Intraday time series
  - Daily, weekly, and monthly adjusted time series
  - Bulk realtime quotes
- `OptionData`
  - Realtime options chains
  - Historical options chains
- `CommodityData`
  - WTI, Brent, natural gas
  - Copper, aluminum
  - Wheat, corn, cotton, sugar, coffee
  - Global commodity index
- `FundamentalData`
  - Company overview
  - Insider transactions
  - Earnings transcripts
  - Dividends
  - Stock splits
  - Income statement
  - Balance sheet
  - Cash flow
  - Earnings history
  - Earnings estimates
- `FXData`
  - Realtime exchange rate quote
  - Intraday, daily, weekly, monthly FX series
- `CryptoData`
  - Realtime exchange rate quote
  - Intraday, daily, weekly, monthly crypto series
- `EconomicData`
  - Real GDP
  - Real GDP per capita
  - CPI
  - Inflation
  - Retail sales
  - Durable goods orders
  - Non-farm payrolls
  - Unemployment rate
- `FixedIncomeData`
  - U.S. Treasury yields
  - Federal funds rate

## Highlights

- Unified entry point through `AlphaVantageAPI`
- Async-first API surface
- Strongly typed response models
- Static parsing helpers for JSON and CSV fixtures
- Optional raw response logging callback
- xUnit tests with sample response files for parser validation

## Target framework

This project currently targets:

```xml
<TargetFramework>net10.0</TargetFramework>
```

That makes it a modern .NET library, but it also means consumers need a compatible .NET SDK/runtime.

## Installation

### Option 1: reference the project directly

```bash
dotnet add reference path/to/DeepSigma.AlphaVantageAPI.csproj
```

### Option 2: add the NuGet package

If you publish or consume this library through NuGet, use the package ID associated with the project/package configuration in your feed.

```bash
dotnet add package DeepSigma.AlphaVantageAPI
```

## Getting an API key

Create an Alpha Vantage API key from the Alpha Vantage website, then pass it into the client constructor:

```csharp
using DeepSigma.AlphaVantageAPI;

var api = new AlphaVantageAPI("YOUR_ALPHA_VANTAGE_API_KEY");
```

You can also provide a logger callback to inspect raw responses:

```csharp
var api = new AlphaVantageAPI(
    "YOUR_ALPHA_VANTAGE_API_KEY",
    json => Console.WriteLine(json)
);
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
using DeepSigma.AlphaVantageAPI;
using DeepSigma.AlphaVantageAPI.DataModels;

string json = File.ReadAllText("AVCompanyOverview.json");

AVComanyOverview? overview = FundamentalData.GetCompanyOverviewFromJson(json);

if (overview is not null)
{
    Console.WriteLine(overview.Name);
}
```

### Parse CSV utility responses

```csharp
using DeepSigma.AlphaVantageAPI;
using DeepSigma.AlphaVantageAPI.DataModels;

string csv = File.ReadAllText("earnings_calendar.csv");

List<AVEarningsCalandarCSVData> rows = UtilitiesData.GetEarningsFromCSV(csv);

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

// Fundamentals
await api.FundamentalData.GetCompanyOverview("MSFT");
await api.FundamentalData.GetBalanceSheet("MSFT");
await api.FundamentalData.GetCashFlow("MSFT");
await api.FundamentalData.GetEarningsTranscript("MSFT", 2025, 1);

// Macro / rates
await api.EconomicData.GetInflation();
await api.FixedIncomeData.GetUSTreasuryYield(FixedIncomeMaturities.TenYear);
await api.FixedIncomeData.GetFedFunds();
```

## Running tests

The repository includes an xUnit test project plus fixture files under `DeepSigma.DataAccess.AlphaVantage.Tests/TestData`.

Run the test suite with:

```bash
dotnet test
```

The tests focus heavily on parser correctness by loading stored JSON/CSV samples and confirming that expected models are populated.

## Project structure

```text
.
├── DeepSigma.DataAccess.AlphaVantage
│   ├── AlphaVantageAPI.cs
│   ├── UtilitiesData.cs
│   ├── StockData.cs
│   ├── OptionData.cs
│   ├── CommodityData.cs
│   ├── FundamentalData.cs
│   ├── FXData.cs
│   ├── CryptoData.cs
│   ├── EconomicData.cs
│   ├── FixedIncomeData.cs
│   ├── DataModels/
│   ├── Enums/
│   └── Parsers/
└── DeepSigma.DataAccess.AlphaVantage.Tests
    ├── Tests/
    └── TestData/
```

## Notes and caveats

- Alpha Vantage rate limits still apply.
- Some endpoint names in the code mirror Alpha Vantage naming very closely, including a few existing spelling inconsistencies such as `GetHistroicalNews`, `GetEarningsCalandar`, and `GetIPOCalandar`.
- The project depends on `DeepSigma.DataAccess` for HTTP and serialization utilities.
- The codebase is designed around Alpha Vantage response shapes, so static parser helpers are a first-class part of the API.

## Why this repo is useful

This repository is more than a thin HTTP wrapper. It already includes:

- typed models for a wide span of Alpha Vantage endpoints
- a single facade for discoverability
- reusable parsers
- test fixtures that make regression testing straightforward

That combination makes it useful both for application developers and for teams that want deterministic tests around market-data response parsing.

## License

No license file was included in the provided repository snapshot. Add a `LICENSE` file if you want consumers to know the terms of use clearly.
