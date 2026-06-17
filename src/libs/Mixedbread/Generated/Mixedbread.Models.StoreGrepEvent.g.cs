
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Represents a grep event in a vector store.<br/>
    /// Grep matches chunks against a regular expression rather than running a<br/>
    /// semantic search, so it has no ranking, rewrite, or rerank fields.
    /// </summary>
    public sealed partial class StoreGrepEvent
    {
        /// <summary>
        /// Unique identifier for the event
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Timestamp when the event was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Default Value: grep
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// IDs of the vector stores grepped
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> StoreIds { get; set; }

        /// <summary>
        /// Regular expression matched against chunk text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        /// Whether the pattern was matched case-sensitively<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("case_sensitive")]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// Time taken to grep the vector store<br/>
        /// Default Value: PT0S
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_time")]
        public string? SearchTime { get; set; }

        /// <summary>
        /// Metadata filters submitted with the grep request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>, object>))]
        public global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>, object>? Filters { get; set; }

        /// <summary>
        /// Chunks that matched the pattern
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Mixedbread.StoreSearchEventResult>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreGrepEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the event
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the event was created
        /// </param>
        /// <param name="storeIds">
        /// IDs of the vector stores grepped
        /// </param>
        /// <param name="type">
        /// Default Value: grep
        /// </param>
        /// <param name="pattern">
        /// Regular expression matched against chunk text
        /// </param>
        /// <param name="caseSensitive">
        /// Whether the pattern was matched case-sensitively<br/>
        /// Default Value: false
        /// </param>
        /// <param name="searchTime">
        /// Time taken to grep the vector store<br/>
        /// Default Value: PT0S
        /// </param>
        /// <param name="filters">
        /// Metadata filters submitted with the grep request
        /// </param>
        /// <param name="results">
        /// Chunks that matched the pattern
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreGrepEvent(
            global::System.Guid id,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<global::System.Guid> storeIds,
            string? type,
            string? pattern,
            bool? caseSensitive,
            string? searchTime,
            global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<global::Mixedbread.SearchFilterOutput, global::Mixedbread.SearchFilterCondition>>, object>? filters,
            global::System.Collections.Generic.IList<global::Mixedbread.StoreSearchEventResult>? results)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Type = type;
            this.StoreIds = storeIds ?? throw new global::System.ArgumentNullException(nameof(storeIds));
            this.Pattern = pattern;
            this.CaseSensitive = caseSensitive;
            this.SearchTime = searchTime;
            this.Filters = filters;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreGrepEvent" /> class.
        /// </summary>
        public StoreGrepEvent()
        {
        }

    }
}