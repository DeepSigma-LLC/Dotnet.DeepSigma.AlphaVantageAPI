using System.ComponentModel;

namespace DeepSigma.AlphaVantageAPI.Enums;

/// <summary>
/// Specifies the format in which data is returned from the Alpha Vantage API.
/// </summary>
public enum DataReturnType
{
    /// <summary>
    /// Represents the JSON format for serialization or deserialization.
    /// </summary>
    /// <remarks>This enumeration value is typically used to specify that data should be processed in
    /// JSON format.</remarks>
    [Description("json")]
    Json,
    /// <summary>
    /// Represents the CSV (Comma-Separated Values) file format.
    /// </summary>
    /// <remarks>This enumeration value is typically used to specify or identify the CSV format in
    /// contexts such as file processing, data export, or import operations.</remarks>
    [Description("csv")]
    CSV
}
