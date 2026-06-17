
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public enum IntegrationProviderManifestIngestionBacking2
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
    public static class IntegrationProviderManifestIngestionBacking2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegrationProviderManifestIngestionBacking2 value)
        {
            return value switch
            {
                IntegrationProviderManifestIngestionBacking2.DataSourceConnector => "data_source_connector",
                IntegrationProviderManifestIngestionBacking2.IntegrationJob => "integration_job",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegrationProviderManifestIngestionBacking2? ToEnum(string value)
        {
            return value switch
            {
                "data_source_connector" => IntegrationProviderManifestIngestionBacking2.DataSourceConnector,
                "integration_job" => IntegrationProviderManifestIngestionBacking2.IntegrationJob,
                _ => null,
            };
        }
    }
}