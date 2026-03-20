
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorStoreFileChunksVariant1ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.VectorStoreFileChunksVariant1ItemDiscriminatorTypeJsonConverter))]
        public global::Mixedbread.VectorStoreFileChunksVariant1ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileChunksVariant1ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorStoreFileChunksVariant1ItemDiscriminator(
            global::Mixedbread.VectorStoreFileChunksVariant1ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreFileChunksVariant1ItemDiscriminator" /> class.
        /// </summary>
        public VectorStoreFileChunksVariant1ItemDiscriminator()
        {
        }
    }
}