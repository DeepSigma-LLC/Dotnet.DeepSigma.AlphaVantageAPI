
namespace DeepSigma.DataAccess.AlphaVantage.DataModels
{
    public class AVGenericObject
    {
        /// <summary>
        /// Any fields that were not mapped to properties in this object
        /// </summary>
        public IReadOnlyDictionary<string, string> UnmappedFields { get; init; } = new Dictionary<string, string>();
    }
}
