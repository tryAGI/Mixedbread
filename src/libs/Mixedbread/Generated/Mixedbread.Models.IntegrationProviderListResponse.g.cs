
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// List of supported integration providers.
    /// </summary>
    public sealed partial class IntegrationProviderListResponse
    {
        /// <summary>
        /// Supported integration providers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mixedbread.IntegrationProviderManifest> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationProviderListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Supported integration providers
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationProviderListResponse(
            global::System.Collections.Generic.IList<global::Mixedbread.IntegrationProviderManifest> data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationProviderListResponse" /> class.
        /// </summary>
        public IntegrationProviderListResponse()
        {
        }

    }
}