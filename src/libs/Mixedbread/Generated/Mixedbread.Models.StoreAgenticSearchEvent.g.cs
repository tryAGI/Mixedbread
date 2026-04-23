
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Represents an agentic search trace in a vector store.<br/>
    /// Unlike StoreSearchEvent, this captures the full sequence of tool calls the<br/>
    /// agent issued (name, arguments, result) so developers can inspect what the<br/>
    /// agent did, along with the token usage and cost.
    /// </summary>
    public sealed partial class StoreAgenticSearchEvent
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
        /// Default Value: agentic_search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// IDs of the vector stores searched
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> StoreIds { get; set; }

        /// <summary>
        /// Time when the agentic search began
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// Total wall-clock time of the agent loop<br/>
        /// Default Value: PT0S
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_time")]
        public string? SearchTime { get; set; }

        /// <summary>
        /// Original query submitted by the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Number of search rounds the agent executed<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rounds_executed")]
        public int? RoundsExecuted { get; set; }

        /// <summary>
        /// Token usage and cost for LLM calls during the agentic search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_usage")]
        public global::Mixedbread.AgenticSearchTokenUsage? TokenUsage { get; set; }

        /// <summary>
        /// Ordered tool calls issued by the agent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_calls")]
        public global::System.Collections.Generic.IList<global::Mixedbread.AgenticToolCall>? ToolCalls { get; set; }

        /// <summary>
        /// Chunks returned by the agentic search
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Mixedbread.StoreSearchEventResult>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreAgenticSearchEvent" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the event
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the event was created
        /// </param>
        /// <param name="storeIds">
        /// IDs of the vector stores searched
        /// </param>
        /// <param name="startedAt">
        /// Time when the agentic search began
        /// </param>
        /// <param name="query">
        /// Original query submitted by the user
        /// </param>
        /// <param name="type">
        /// Default Value: agentic_search
        /// </param>
        /// <param name="searchTime">
        /// Total wall-clock time of the agent loop<br/>
        /// Default Value: PT0S
        /// </param>
        /// <param name="roundsExecuted">
        /// Number of search rounds the agent executed<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="tokenUsage">
        /// Token usage and cost for LLM calls during the agentic search
        /// </param>
        /// <param name="toolCalls">
        /// Ordered tool calls issued by the agent
        /// </param>
        /// <param name="results">
        /// Chunks returned by the agentic search
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StoreAgenticSearchEvent(
            global::System.Guid id,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.IList<global::System.Guid> storeIds,
            global::System.DateTime startedAt,
            string query,
            string? type,
            string? searchTime,
            int? roundsExecuted,
            global::Mixedbread.AgenticSearchTokenUsage? tokenUsage,
            global::System.Collections.Generic.IList<global::Mixedbread.AgenticToolCall>? toolCalls,
            global::System.Collections.Generic.IList<global::Mixedbread.StoreSearchEventResult>? results)
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Type = type;
            this.StoreIds = storeIds ?? throw new global::System.ArgumentNullException(nameof(storeIds));
            this.StartedAt = startedAt;
            this.SearchTime = searchTime;
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.RoundsExecuted = roundsExecuted;
            this.TokenUsage = tokenUsage;
            this.ToolCalls = toolCalls;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StoreAgenticSearchEvent" /> class.
        /// </summary>
        public StoreAgenticSearchEvent()
        {
        }
    }
}