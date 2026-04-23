
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// The type of event to list
    /// </summary>
    public enum ListStoreEventsEventType
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
    public static class ListStoreEventsEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListStoreEventsEventType value)
        {
            return value switch
            {
                ListStoreEventsEventType.AgenticSearch => "agentic_search",
                ListStoreEventsEventType.Ingestion => "ingestion",
                ListStoreEventsEventType.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListStoreEventsEventType? ToEnum(string value)
        {
            return value switch
            {
                "agentic_search" => ListStoreEventsEventType.AgenticSearch,
                "ingestion" => ListStoreEventsEventType.Ingestion,
                "search" => ListStoreEventsEventType.Search,
                _ => null,
            };
        }
    }
}