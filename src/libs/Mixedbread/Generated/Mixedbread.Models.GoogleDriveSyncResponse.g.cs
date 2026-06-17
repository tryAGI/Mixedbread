
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Google Drive manual sync response.
    /// </summary>
    public sealed partial class GoogleDriveSyncResponse
    {
        /// <summary>
        /// Google Drive manual sync result
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mixedbread.GoogleDriveSync Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveSyncResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Google Drive manual sync result
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleDriveSyncResponse(
            global::Mixedbread.GoogleDriveSync data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveSyncResponse" /> class.
        /// </summary>
        public GoogleDriveSyncResponse()
        {
        }

    }
}