
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Configuration for agentic multi-query search.
    /// </summary>
    public sealed partial class AgenticSearchConfig
    {
        /// <summary>
        /// Maximum number of search rounds<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_rounds")]
        public int? MaxRounds { get; set; }

        /// <summary>
        /// Maximum queries per round<br/>
        /// Default Value: 4
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries_per_round")]
        public int? QueriesPerRound { get; set; }

        /// <summary>
        /// Whether the final retrieved chunk list must provide exactly top_k ranked chunks<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict_top_k")]
        public bool? StrictTopK { get; set; }

        /// <summary>
        /// Controls when retrieved image content is provided to the agent. `auto` sends images only when no OCR text or summary is available, `never` disables image content, and `always` sends image content when available.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("media_content")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.AgenticSearchConfigMediaContentJsonConverter))]
        public global::Mixedbread.AgenticSearchConfigMediaContent? MediaContent { get; set; }

        /// <summary>
        /// Additional custom instructions (followed only when not in conflict with existing rules)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// Internal: when set, the response includes a `trace` field with the full tool-call timeline. Used by the Mixedbread playground; not part of the documented public API.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbose")]
        public bool? Verbose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticSearchConfig" /> class.
        /// </summary>
        /// <param name="maxRounds">
        /// Maximum number of search rounds<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="queriesPerRound">
        /// Maximum queries per round<br/>
        /// Default Value: 4
        /// </param>
        /// <param name="strictTopK">
        /// Whether the final retrieved chunk list must provide exactly top_k ranked chunks<br/>
        /// Default Value: false
        /// </param>
        /// <param name="mediaContent">
        /// Controls when retrieved image content is provided to the agent. `auto` sends images only when no OCR text or summary is available, `never` disables image content, and `always` sends image content when available.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="instructions">
        /// Additional custom instructions (followed only when not in conflict with existing rules)
        /// </param>
        /// <param name="verbose">
        /// Internal: when set, the response includes a `trace` field with the full tool-call timeline. Used by the Mixedbread playground; not part of the documented public API.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgenticSearchConfig(
            int? maxRounds,
            int? queriesPerRound,
            bool? strictTopK,
            global::Mixedbread.AgenticSearchConfigMediaContent? mediaContent,
            string? instructions,
            bool? verbose)
        {
            this.MaxRounds = maxRounds;
            this.QueriesPerRound = queriesPerRound;
            this.StrictTopK = strictTopK;
            this.MediaContent = mediaContent;
            this.Instructions = instructions;
            this.Verbose = verbose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticSearchConfig" /> class.
        /// </summary>
        public AgenticSearchConfig()
        {
        }

    }
}