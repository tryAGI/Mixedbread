
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public enum StoreEventHistogramParamsEventTypesVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        AgenticSearch,
        /// <summary>
        /// 
        /// </summary>
        Ingestion,
        /// <summary>
        /// 
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StoreEventHistogramParamsEventTypesVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreEventHistogramParamsEventTypesVariant1Item value)
        {
            return value switch
            {
                StoreEventHistogramParamsEventTypesVariant1Item.AgenticSearch => "agentic_search",
                StoreEventHistogramParamsEventTypesVariant1Item.Ingestion => "ingestion",
                StoreEventHistogramParamsEventTypesVariant1Item.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreEventHistogramParamsEventTypesVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "agentic_search" => StoreEventHistogramParamsEventTypesVariant1Item.AgenticSearch,
                "ingestion" => StoreEventHistogramParamsEventTypesVariant1Item.Ingestion,
                "search" => StoreEventHistogramParamsEventTypesVariant1Item.Search,
                _ => null,
            };
        }
    }
}