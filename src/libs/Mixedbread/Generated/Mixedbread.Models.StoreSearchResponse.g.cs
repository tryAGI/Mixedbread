
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StoreSearchResponse
    {
        /// <summary>
        /// The object type of the response<br/>
        /// Default Value: list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The list of scored store file chunks
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mixedbread.DataItem2> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreSearchResponse" /> class.
        /// </summary>
        /// <param name="object">
        /// The object type of the response<br/>
        /// Default Value: list
        /// </param>
        /// <param name="data">
        /// The list of scored store file chunks
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreSearchResponse(
            global::System.Collections.Generic.IList<global::Mixedbread.DataItem2> data,
            string? @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreSearchResponse" /> class.
        /// </summary>
        public StoreSearchResponse()
        {
        }
    }
}