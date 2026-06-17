
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Google Drive folder selection update response.
    /// </summary>
    public sealed partial class GoogleDriveFolderSelectionUpdateResponse
    {
        /// <summary>
        /// Google Drive folder selection update
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mixedbread.GoogleDriveFolderSelectionUpdate Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveFolderSelectionUpdateResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Google Drive folder selection update
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleDriveFolderSelectionUpdateResponse(
            global::Mixedbread.GoogleDriveFolderSelectionUpdate data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveFolderSelectionUpdateResponse" /> class.
        /// </summary>
        public GoogleDriveFolderSelectionUpdateResponse()
        {
        }

    }
}