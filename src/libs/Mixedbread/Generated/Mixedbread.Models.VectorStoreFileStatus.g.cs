
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public enum VectorStoreFileStatus
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
    public static class VectorStoreFileStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VectorStoreFileStatus value)
        {
            return value switch
            {
                VectorStoreFileStatus.Pending => "pending",
                VectorStoreFileStatus.InProgress => "in_progress",
                VectorStoreFileStatus.Cancelled => "cancelled",
                VectorStoreFileStatus.Completed => "completed",
                VectorStoreFileStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VectorStoreFileStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => VectorStoreFileStatus.Pending,
                "in_progress" => VectorStoreFileStatus.InProgress,
                "cancelled" => VectorStoreFileStatus.Cancelled,
                "completed" => VectorStoreFileStatus.Completed,
                "failed" => VectorStoreFileStatus.Failed,
                _ => null,
            };
        }
    }
}