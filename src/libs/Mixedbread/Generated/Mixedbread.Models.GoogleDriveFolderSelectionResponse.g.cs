
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Google Drive folder selection response.
    /// </summary>
    public sealed partial class GoogleDriveFolderSelectionResponse
    {
        /// <summary>
        /// Google Drive folder selection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mixedbread.GoogleDriveFolderSelection Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveFolderSelectionResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Google Drive folder selection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GoogleDriveFolderSelectionResponse(
            global::Mixedbread.GoogleDriveFolderSelection data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleDriveFolderSelectionResponse" /> class.
        /// </summary>
        public GoogleDriveFolderSelectionResponse()
        {
        }

    }
}