
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Ranking request based on metadata.
    /// </summary>
    public sealed partial class QueryEnhanceSortItem
    {
        /// <summary>
        /// Default Value: sort
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.QueryEnhanceSortItemFilterModeJsonConverter))]
        public global::Mixedbread.QueryEnhanceSortItemFilterMode? FilterMode { get; set; }

        /// <summary>
        /// Metadata field to rank results by
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank_by")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RankBy { get; set; }

        /// <summary>
        /// Ranking direction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.QueryEnhanceSortItemDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mixedbread.QueryEnhanceSortItemDirection Direction { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryEnhanceSortItem" /> class.
        /// </summary>
        /// <param name="rankBy">
        /// Metadata field to rank results by
        /// </param>
        /// <param name="direction">
        /// Ranking direction
        /// </param>
        /// <param name="type">
        /// Default Value: sort
        /// </param>
        /// <param name="metadataFilters">
        /// Metadata filters to apply
        /// </param>
        /// <param name="filterMode">
        /// How to combine filters<br/>
        /// Default Value: all
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryEnhanceSortItem(
            string rankBy,
            global::Mixedbread.QueryEnhanceSortItemDirection direction,
            string? type,
            global::System.Collections.Generic.IList<global::Mixedbread.QueryEnhanceMetadataFilter>? metadataFilters,
            global::Mixedbread.QueryEnhanceSortItemFilterMode? filterMode)
        {
            this.Type = type;
            this.MetadataFilters = metadataFilters;
            this.FilterMode = filterMode;
            this.RankBy = rankBy ?? throw new global::System.ArgumentNullException(nameof(rankBy));
            this.Direction = direction;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryEnhanceSortItem" /> class.
        /// </summary>
        public QueryEnhanceSortItem()
        {
        }

    }
}