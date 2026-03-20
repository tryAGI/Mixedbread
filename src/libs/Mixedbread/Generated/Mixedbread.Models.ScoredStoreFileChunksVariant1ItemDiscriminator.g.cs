
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ScoredStoreFileChunksVariant1ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.ScoredStoreFileChunksVariant1ItemDiscriminatorTypeJsonConverter))]
        public global::Mixedbread.ScoredStoreFileChunksVariant1ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoredStoreFileChunksVariant1ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScoredStoreFileChunksVariant1ItemDiscriminator(
            global::Mixedbread.ScoredStoreFileChunksVariant1ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoredStoreFileChunksVariant1ItemDiscriminator" /> class.
        /// </summary>
        public ScoredStoreFileChunksVariant1ItemDiscriminator()
        {
        }
    }
}