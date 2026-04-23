
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public enum StoreEventListResponseDataItemDiscriminatorType
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
    public static class StoreEventListResponseDataItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreEventListResponseDataItemDiscriminatorType value)
        {
            return value switch
            {
                StoreEventListResponseDataItemDiscriminatorType.AgenticSearch => "agentic_search",
                StoreEventListResponseDataItemDiscriminatorType.Ingestion => "ingestion",
                StoreEventListResponseDataItemDiscriminatorType.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreEventListResponseDataItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "agentic_search" => StoreEventListResponseDataItemDiscriminatorType.AgenticSearch,
                "ingestion" => StoreEventListResponseDataItemDiscriminatorType.Ingestion,
                "search" => StoreEventListResponseDataItemDiscriminatorType.Search,
                _ => null,
            };
        }
    }
}