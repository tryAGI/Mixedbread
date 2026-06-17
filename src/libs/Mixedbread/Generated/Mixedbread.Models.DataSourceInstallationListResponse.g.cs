
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// List of all connected data sources across providers.
    /// </summary>
    public sealed partial class DataSourceInstallationListResponse
    {
        /// <summary>
        /// Connected data sources
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mixedbread.DataSourceInstallation> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceInstallationListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Connected data sources
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataSourceInstallationListResponse(
            global::System.Collections.Generic.IList<global::Mixedbread.DataSourceInstallation> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSourceInstallationListResponse" /> class.
        /// </summary>
        public DataSourceInstallationListResponse()
        {
        }

    }
}