
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// The integration provider identifier
    /// </summary>
    public enum IntegrationProviderManifestProvider
    {
        /// <summary>
        /// 
        /// </summary>
        GoogleDrive,
        /// <summary>
        /// 
        /// </summary>
        Linear,
        /// <summary>
        /// 
        /// </summary>
        Notion,
        /// <summary>
        /// 
        /// </summary>
        Slack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntegrationProviderManifestProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationProviderManifestProvider value)
        {
            return value switch
            {
                IntegrationProviderManifestProvider.GoogleDrive => "google_drive",
                IntegrationProviderManifestProvider.Linear => "linear",
                IntegrationProviderManifestProvider.Notion => "notion",
                IntegrationProviderManifestProvider.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationProviderManifestProvider? ToEnum(string value)
        {
            return value switch
            {
                "google_drive" => IntegrationProviderManifestProvider.GoogleDrive,
                "linear" => IntegrationProviderManifestProvider.Linear,
                "notion" => IntegrationProviderManifestProvider.Notion,
                "slack" => IntegrationProviderManifestProvider.Slack,
                _ => null,
            };
        }
    }
}