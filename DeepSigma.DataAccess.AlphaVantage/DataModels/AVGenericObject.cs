
namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    /// <summary>
    /// A generic object to capture all fields from Alpha Vantage API responses.
    /// </summary>
    public class AVGenericObject
    {
        /// <summary>
        /// Any fields that were not mapped to properties in this object
        /// </summary>
        public IReadOnlyDictionary<string, string> AllFields { get; init; } = new Dictionary<string, string>();
    }
}
