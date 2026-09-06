
#nullable enable

namespace Mixedbread
{
    /// <summary>
    ///
    /// </summary>
    public enum IntegrationProviderManifestIngestionBacking
    {
        /// <summary>
        ///
        /// </summary>
        DataSourceConnector,
        /// <summary>
        ///
        /// </summary>
        IntegrationJob,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntegrationProviderManifestIngestionBackingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationProviderManifestIngestionBacking value)
        {
            return value switch
            {
                IntegrationProviderManifestIngestionBacking.DataSourceConnector => "data_source_connector",
                IntegrationProviderManifestIngestionBacking.IntegrationJob => "integration_job",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationProviderManifestIngestionBacking? ToEnum(string value)
        {
            return value switch
            {
                "data_source_connector" => IntegrationProviderManifestIngestionBacking.DataSourceConnector,
                "integration_job" => IntegrationProviderManifestIngestionBacking.IntegrationJob,
                _ => null,
            };
        }
    }
}