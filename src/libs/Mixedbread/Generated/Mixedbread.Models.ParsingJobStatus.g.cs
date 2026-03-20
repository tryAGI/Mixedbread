
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public enum ParsingJobStatus
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
    public static class ParsingJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ParsingJobStatus value)
        {
            return value switch
            {
                ParsingJobStatus.Pending => "pending",
                ParsingJobStatus.InProgress => "in_progress",
                ParsingJobStatus.Cancelled => "cancelled",
                ParsingJobStatus.Completed => "completed",
                ParsingJobStatus.Failed => "failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ParsingJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "pending" => ParsingJobStatus.Pending,
                "in_progress" => ParsingJobStatus.InProgress,
                "cancelled" => ParsingJobStatus.Cancelled,
                "completed" => ParsingJobStatus.Completed,
                "failed" => ParsingJobStatus.Failed,
                _ => null,
            };
        }
    }
}