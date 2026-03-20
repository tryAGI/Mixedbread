
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Status of a store.
    /// </summary>
    public enum StoreStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StoreStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreStatus value)
        {
            return value switch
            {
                StoreStatus.Expired => "expired",
                StoreStatus.InProgress => "in_progress",
                StoreStatus.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreStatus? ToEnum(string value)
        {
            return value switch
            {
                "expired" => StoreStatus.Expired,
                "in_progress" => StoreStatus.InProgress,
                "completed" => StoreStatus.Completed,
                _ => null,
            };
        }
    }
}