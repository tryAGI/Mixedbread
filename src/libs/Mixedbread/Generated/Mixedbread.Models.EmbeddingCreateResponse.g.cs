
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingCreateResponse
    {
        /// <summary>
        /// The usage of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mixedbread.Usage Usage { get; set; }

        /// <summary>
        /// The model used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The created embeddings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.Embedding>, global::System.Collections.Generic.IList<global::Mixedbread.MultiEncodingEmbedding>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mixedbread.AnyOf<global::System.Collections.Generic.IList<global::Mixedbread.Embedding>, global::System.Collections.Generic.IList<global::Mixedbread.MultiEncodingEmbedding>> Data { get; set; }

        /// <summary>
        /// The object type of the response<br/>
        /// Default Value: list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// Whether the embeddings are normalized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Normalized { get; set; }

        /// <summary>
        /// The encoding formats of the embeddings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encoding_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.EncodingFormat3?, global::System.Collections.Generic.IList<global::Mixedbread.EncodingFormat3>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mixedbread.AnyOf<global::Mixedbread.EncodingFormat3?, global::System.Collections.Generic.IList<global::Mixedbread.EncodingFormat3>> EncodingFormat { get; set; }

        /// <summary>
        /// The number of dimensions used for the embeddings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimensions")]
        public int? Dimensions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingCreateResponse" /> class.
        /// </summary>
        /// <param name="usage">
        /// The usage of the model
        /// </param>
        /// <param name="model">
        /// The model used
        /// </param>
        /// <param name="data">
        /// The created embeddings.
        /// </param>
        /// <param name="object">
        /// The object type of the response<br/>
        /// Default Value: list
        /// </param>
        /// <param name="normalized">
        /// Whether the embeddings are normalized.
        /// </param>
        /// <param name="encodingFormat">
        /// The encoding formats of the embeddings.
        /// </param>
        /// <param name="dimensions">
        /// The number of dimensions used for the embeddings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingCreateResponse(
            global::Mixedbread.Usage usage,
            string model,
            global::Mixedbread.AnyOf<global::System.Collections.Generic.IList<global::Mixedbread.Embedding>, global::System.Collections.Generic.IList<global::Mixedbread.MultiEncodingEmbedding>> data,
            bool normalized,
            global::Mixedbread.AnyOf<global::Mixedbread.EncodingFormat3?, global::System.Collections.Generic.IList<global::Mixedbread.EncodingFormat3>> encodingFormat,
            string? @object,
            int? dimensions)
        {
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Data = data;
            this.Normalized = normalized;
            this.EncodingFormat = encodingFormat;
            this.Object = @object;
            this.Dimensions = dimensions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingCreateResponse" /> class.
        /// </summary>
        public EmbeddingCreateResponse()
        {
        }
    }
}