
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Enhanced semantic search query with optional filters.
    /// </summary>
    public sealed partial class QueryEnhanceQueryItem
    {
        /// <summary>
        /// Default Value: query
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Search query text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Metadata filters to apply
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_filters")]
        public global::System.Collections.Generic.IList<global::Mixedbread.QueryEnhanceMetadataFilter>? MetadataFilters { get; set; }

        /// <summary>
        /// How to combine filters<br/>
        /// Default Value: all
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.QueryEnhanceQueryItemFilterModeJsonConverter))]
        public global::Mixedbread.QueryEnhanceQueryItemFilterMode? FilterMode { get; set; }

        /// <summary>
        /// Always null for semantic query items. Use a sort item to rank by metadata.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank_by")]
        public object? RankBy { get; set; }

        /// <summary>
        /// Always null for semantic query items. Use a sort item to set rank direction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        public object? Direction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryEnhanceQueryItem" /> class.
        /// </summary>
        /// <param name="query">
        /// Search query text
        /// </param>
        /// <param name="type">
        /// Default Value: query
        /// </param>
        /// <param name="metadataFilters">
        /// Metadata filters to apply
        /// </param>
        /// <param name="filterMode">
        /// How to combine filters<br/>
        /// Default Value: all
        /// </param>
        /// <param name="rankBy">
        /// Always null for semantic query items. Use a sort item to rank by metadata.
        /// </param>
        /// <param name="direction">
        /// Always null for semantic query items. Use a sort item to set rank direction.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryEnhanceQueryItem(
            string query,
            string? type,
            global::System.Collections.Generic.IList<global::Mixedbread.QueryEnhanceMetadataFilter>? metadataFilters,
            global::Mixedbread.QueryEnhanceQueryItemFilterMode? filterMode,
            object? rankBy,
            object? direction)
        {
            this.Type = type;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.MetadataFilters = metadataFilters;
            this.FilterMode = filterMode;
            this.RankBy = rankBy;
            this.Direction = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryEnhanceQueryItem" /> class.
        /// </summary>
        public QueryEnhanceQueryItem()
        {
        }

    }
}