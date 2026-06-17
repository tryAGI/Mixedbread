
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Current Slack ingestion status<br/>
    /// Default Value: not_syncing
    /// </summary>
    public enum SlackChannelSyncStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        NotSyncing,
        /// <summary>
        /// 
        /// </summary>
        Syncing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SlackChannelSyncStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SlackChannelSyncStatus value)
        {
            return value switch
            {
                SlackChannelSyncStatus.Error => "error",
                SlackChannelSyncStatus.NotSyncing => "not_syncing",
                SlackChannelSyncStatus.Syncing => "syncing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SlackChannelSyncStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => SlackChannelSyncStatus.Error,
                "not_syncing" => SlackChannelSyncStatus.NotSyncing,
                "syncing" => SlackChannelSyncStatus.Syncing,
                _ => null,
            };
        }
    }
}