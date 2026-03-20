
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StoreFileListResponse
    {
        /// <summary>
        /// Response model for cursor-based pagination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mixedbread.CursorPaginationResponse Pagination { get; set; }

        /// <summary>
        /// The object type of the response<br/>
        /// Default Value: list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The list of store files
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mixedbread.StoreFile> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreFileListResponse" /> class.
        /// </summary>
        /// <param name="pagination">
        /// Response model for cursor-based pagination.
        /// </param>
        /// <param name="object">
        /// The object type of the response<br/>
        /// Default Value: list
        /// </param>
        /// <param name="data">
        /// The list of store files
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreFileListResponse(
            global::Mixedbread.CursorPaginationResponse pagination,
            global::System.Collections.Generic.IList<global::Mixedbread.StoreFile> data,
            string? @object)
        {
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreFileListResponse" /> class.
        /// </summary>
        public StoreFileListResponse()
        {
        }
    }
}