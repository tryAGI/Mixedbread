
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Request body for updating a Google Drive installation's data source config.
    /// </summary>
    public sealed partial class GoogleDriveInstallationConfigUpdateBody
    {
        /// <summary>
        /// Whether the entire Drive (all current and future files) is synced automatically
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_sync_all")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AutoSyncAll { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveInstallationConfigUpdateBody" /> class.
        /// </summary>
        /// <param name="autoSyncAll">
        /// Whether the entire Drive (all current and future files) is synced automatically
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleDriveInstallationConfigUpdateBody(
            bool autoSyncAll)
        {
            this.AutoSyncAll = autoSyncAll;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveInstallationConfigUpdateBody" /> class.
        /// </summary>
        public GoogleDriveInstallationConfigUpdateBody()
        {
        }

    }
}