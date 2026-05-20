
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Parameters for getting metadata facets.
    /// </summary>
    public sealed partial class MetadataFacetsParams
    {
        /// <summary>
        /// IDs or names of stores
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_identifiers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, global::System.Guid?>> StoreIdentifiers { get; set; }

        /// <summary>
        /// Number of results to return<br/>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_k")]
        public int? TopK { get; set; }

        /// <summary>
        /// Optional filter conditions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>))]
        public global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>? Filters { get; set; }

        /// <summary>
        /// Optional list of file IDs to filter chunks by (inclusion filter)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>))]
        public global::Mixedbread.AnyOf<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>? FileIds { get; set; }

        /// <summary>
        /// Search query text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Search configuration options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_options")]
        public global::Mixedbread.StoreChunkSearchOptions? SearchOptions { get; set; }

        /// <summary>
        /// Optional list of facets to return. Use dot for nested fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("facets")]
        public global::System.Collections.Generic.IList<string>? Facets { get; set; }

        /// <summary>
        /// Maximum number of distinct metadata fields (keys) to return.<br/>
        /// Default Value: 64
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_fields")]
        public int? MaxFields { get; set; }

        /// <summary>
        /// Maximum number of distinct values returned per field, ranked by count.<br/>
        /// Default Value: 32
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_values_per_field")]
        public int? MaxValuesPerField { get; set; }

        /// <summary>
        /// Maximum number of store files scanned to compute facets.<br/>
        /// Default Value: 10000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_files")]
        public int? MaxFiles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataFacetsParams" /> class.
        /// </summary>
        /// <param name="storeIdentifiers">
        /// IDs or names of stores
        /// </param>
        /// <param name="topK">
        /// Number of results to return<br/>
        /// Default Value: 10
        /// </param>
        /// <param name="filters">
        /// Optional filter conditions
        /// </param>
        /// <param name="fileIds">
        /// Optional list of file IDs to filter chunks by (inclusion filter)
        /// </param>
        /// <param name="query">
        /// Search query text
        /// </param>
        /// <param name="searchOptions">
        /// Search configuration options
        /// </param>
        /// <param name="facets">
        /// Optional list of facets to return. Use dot for nested fields.
        /// </param>
        /// <param name="maxFields">
        /// Maximum number of distinct metadata fields (keys) to return.<br/>
        /// Default Value: 64
        /// </param>
        /// <param name="maxValuesPerField">
        /// Maximum number of distinct values returned per field, ranked by count.<br/>
        /// Default Value: 32
        /// </param>
        /// <param name="maxFiles">
        /// Maximum number of store files scanned to compute facets.<br/>
        /// Default Value: 10000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataFacetsParams(
            global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, global::System.Guid?>> storeIdentifiers,
            int? topK,
            global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterInput, global::Mixedbread.SearchFilterCondition>>, object>? filters,
            global::Mixedbread.AnyOf<global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.ConditionOperator?, global::System.Collections.Generic.IList<global::System.Guid>>>, global::System.Collections.Generic.IList<global::System.Guid>, object>? fileIds,
            string? query,
            global::Mixedbread.StoreChunkSearchOptions? searchOptions,
            global::System.Collections.Generic.IList<string>? facets,
            int? maxFields,
            int? maxValuesPerField,
            int? maxFiles)
        {
            this.StoreIdentifiers = storeIdentifiers ?? throw new global::System.ArgumentNullException(nameof(storeIdentifiers));
            this.TopK = topK;
            this.Filters = filters;
            this.FileIds = fileIds;
            this.Query = query;
            this.SearchOptions = searchOptions;
            this.Facets = facets;
            this.MaxFields = maxFields;
            this.MaxValuesPerField = maxValuesPerField;
            this.MaxFiles = maxFiles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataFacetsParams" /> class.
        /// </summary>
        public MetadataFacetsParams()
        {
        }

    }
}