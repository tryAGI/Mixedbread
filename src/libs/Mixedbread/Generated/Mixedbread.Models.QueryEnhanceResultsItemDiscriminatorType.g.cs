
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryEnhanceResultsItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Query,
        /// <summary>
        /// 
        /// </summary>
        Sort,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryEnhanceResultsItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryEnhanceResultsItemDiscriminatorType value)
        {
            return value switch
            {
                QueryEnhanceResultsItemDiscriminatorType.Query => "query",
                QueryEnhanceResultsItemDiscriminatorType.Sort => "sort",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryEnhanceResultsItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "query" => QueryEnhanceResultsItemDiscriminatorType.Query,
                "sort" => QueryEnhanceResultsItemDiscriminatorType.Sort,
                _ => null,
            };
        }
    }
}