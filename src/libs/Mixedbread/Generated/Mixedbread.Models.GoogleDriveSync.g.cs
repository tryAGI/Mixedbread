
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Result of triggering a Google Drive sync.
    /// </summary>
    public sealed partial class GoogleDriveSync
    {
        /// <summary>
        /// Google Drive installation ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("installation_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstallationId { get; set; }

        /// <summary>
        /// Whether an incremental sync was queued
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queued")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Queued { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveSync" /> class.
        /// </summary>
        /// <param name="installationId">
        /// Google Drive installation ID
        /// </param>
        /// <param name="queued">
        /// Whether an incremental sync was queued
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleDriveSync(
            string installationId,
            bool queued)
        {
            this.InstallationId = installationId ?? throw new global::System.ArgumentNullException(nameof(installationId));
            this.Queued = queued;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveSync" /> class.
        /// </summary>
        public GoogleDriveSync()
        {
        }

    }
}