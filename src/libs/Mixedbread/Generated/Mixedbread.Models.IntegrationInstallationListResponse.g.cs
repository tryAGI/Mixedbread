
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// List of integration installations with pagination.
    /// </summary>
    public sealed partial class IntegrationInstallationListResponse
    {
        /// <summary>
        /// Integration installations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mixedbread.IntegrationInstallation> Data { get; set; }

        /// <summary>
        /// Pagination information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mixedbread.CursorPaginationResponse Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationInstallationListResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Integration installations
        /// </param>
        /// <param name="pagination">
        /// Pagination information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationInstallationListResponse(
            global::System.Collections.Generic.IList<global::Mixedbread.IntegrationInstallation> data,
            global::Mixedbread.CursorPaginationResponse pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationInstallationListResponse" /> class.
        /// </summary>
        public IntegrationInstallationListResponse()
        {
        }

    }
}