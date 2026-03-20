
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public enum SyncStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Idle,
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
    public static class SyncStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SyncStatus value)
        {
            return value switch
            {
                SyncStatus.Idle => "idle",
                SyncStatus.Pending => "pending",
                SyncStatus.InProgress => "in_progress",
                SyncStatus.Cancelled => "cancelled",
                SyncStatus.Completed => "completed",
                SyncStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SyncStatus? ToEnum(string value)
        {
            return value switch
            {
                "idle" => SyncStatus.Idle,
                "pending" => SyncStatus.Pending,
                "in_progress" => SyncStatus.InProgress,
                "cancelled" => SyncStatus.Cancelled,
                "completed" => SyncStatus.Completed,
                "failed" => SyncStatus.Failed,
                _ => null,
            };
        }
    }
}