
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public enum IntegrationProviderManifestCapabilitie
    {
        /// <summary>
        /// 
        /// </summary>
        ExternalAction,
        /// <summary>
        /// 
        /// </summary>
        IngestToStore,
        /// <summary>
        /// 
        /// </summary>
        Notify,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntegrationProviderManifestCapabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationProviderManifestCapabilitie value)
        {
            return value switch
            {
                IntegrationProviderManifestCapabilitie.ExternalAction => "external_action",
                IntegrationProviderManifestCapabilitie.IngestToStore => "ingest_to_store",
                IntegrationProviderManifestCapabilitie.Notify => "notify",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationProviderManifestCapabilitie? ToEnum(string value)
        {
            return value switch
            {
                "external_action" => IntegrationProviderManifestCapabilitie.ExternalAction,
                "ingest_to_store" => IntegrationProviderManifestCapabilitie.IngestToStore,
                "notify" => IntegrationProviderManifestCapabilitie.Notify,
                _ => null,
            };
        }
    }
}