
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public enum SlackChannelLastSyncStatus2
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SlackChannelLastSyncStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SlackChannelLastSyncStatus2 value)
        {
            return value switch
            {
                SlackChannelLastSyncStatus2.Completed => "completed",
                SlackChannelLastSyncStatus2.Error => "error",
                SlackChannelLastSyncStatus2.InProgress => "in_progress",
                SlackChannelLastSyncStatus2.Queued => "queued",
                SlackChannelLastSyncStatus2.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SlackChannelLastSyncStatus2? ToEnum(string value)
        {
            return value switch
            {
                "completed" => SlackChannelLastSyncStatus2.Completed,
                "error" => SlackChannelLastSyncStatus2.Error,
                "in_progress" => SlackChannelLastSyncStatus2.InProgress,
                "queued" => SlackChannelLastSyncStatus2.Queued,
                "skipped" => SlackChannelLastSyncStatus2.Skipped,
                _ => null,
            };
        }
    }
}