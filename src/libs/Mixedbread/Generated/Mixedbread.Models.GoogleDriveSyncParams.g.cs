
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Parameters for manually syncing a Google Drive connector.
    /// </summary>
    public sealed partial class GoogleDriveSyncParams
    {
        /// <summary>
        /// Google Drive installation ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid InstallationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveSyncParams" /> class.
        /// </summary>
        /// <param name="installationId">
        /// Google Drive installation ID
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleDriveSyncParams(
            global::System.Guid installationId)
        {
            this.InstallationId = installationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveSyncParams" /> class.
        /// </summary>
        public GoogleDriveSyncParams()
        {
        }

    }
}