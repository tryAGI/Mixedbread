
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public enum StoreFileStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StoreFileStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreFileStatus value)
        {
            return value switch
            {
                StoreFileStatus.Pending => "pending",
                StoreFileStatus.InProgress => "in_progress",
                StoreFileStatus.Cancelled => "cancelled",
                StoreFileStatus.Completed => "completed",
                StoreFileStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreFileStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => StoreFileStatus.Pending,
                "in_progress" => StoreFileStatus.InProgress,
                "cancelled" => StoreFileStatus.Cancelled,
                "completed" => StoreFileStatus.Completed,
                "failed" => StoreFileStatus.Failed,
                _ => null,
            };
        }
    }
}