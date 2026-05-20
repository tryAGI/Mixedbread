
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// How to combine filters<br/>
    /// Default Value: all
    /// </summary>
    public enum QueryEnhanceSortItemFilterMode
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        Any,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class QueryEnhanceSortItemFilterModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this QueryEnhanceSortItemFilterMode value)
        {
            return value switch
            {
                QueryEnhanceSortItemFilterMode.All => "all",
                QueryEnhanceSortItemFilterMode.Any => "any",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static QueryEnhanceSortItemFilterMode? ToEnum(string value)
        {
            return value switch
            {
                "all" => QueryEnhanceSortItemFilterMode.All,
                "any" => QueryEnhanceSortItemFilterMode.Any,
                _ => null,
            };
        }
    }
}