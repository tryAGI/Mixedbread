
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Primary authorization method
    /// </summary>
    public enum IntegrationProviderManifestAuthType
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
        /// <summary>
        /// 
        /// </summary>
        BotToken,
        /// <summary>
        /// 
        /// </summary>
        Oauth2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntegrationProviderManifestAuthTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationProviderManifestAuthType value)
        {
            return value switch
            {
                IntegrationProviderManifestAuthType.ApiKey => "api_key",
                IntegrationProviderManifestAuthType.BotToken => "bot_token",
                IntegrationProviderManifestAuthType.Oauth2 => "oauth2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationProviderManifestAuthType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => IntegrationProviderManifestAuthType.ApiKey,
                "bot_token" => IntegrationProviderManifestAuthType.BotToken,
                "oauth2" => IntegrationProviderManifestAuthType.Oauth2,
                _ => null,
            };
        }
    }
}