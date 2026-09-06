
#nullable enable

namespace Mixedbread
{
    /// <summary>
    ///
    /// </summary>
    public enum SlackChannelLastSyncStatus
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
    public static class SlackChannelLastSyncStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SlackChannelLastSyncStatus value)
        {
            return value switch
            {
                SlackChannelLastSyncStatus.Completed => "completed",
                SlackChannelLastSyncStatus.Error => "error",
                SlackChannelLastSyncStatus.InProgress => "in_progress",
                SlackChannelLastSyncStatus.Queued => "queued",
                SlackChannelLastSyncStatus.Skipped => "skipped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SlackChannelLastSyncStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => SlackChannelLastSyncStatus.Completed,
                "error" => SlackChannelLastSyncStatus.Error,
                "in_progress" => SlackChannelLastSyncStatus.InProgress,
                "queued" => SlackChannelLastSyncStatus.Queued,
                "skipped" => SlackChannelLastSyncStatus.Skipped,
                _ => null,
            };
        }
    }
}