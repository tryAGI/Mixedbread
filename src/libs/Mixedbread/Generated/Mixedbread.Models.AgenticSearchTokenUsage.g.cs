
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Token usage and cost for LLM calls made during an agentic search.
    /// </summary>
    public sealed partial class AgenticSearchTokenUsage
    {
        /// <summary>
        /// Number of prompt tokens consumed<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// Number of completion tokens generated<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// Total tokens consumed (prompt + completion)<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Estimated cost in USD<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_usd")]
        public double? CostUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticSearchTokenUsage" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// Number of prompt tokens consumed<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="completionTokens">
        /// Number of completion tokens generated<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="totalTokens">
        /// Total tokens consumed (prompt + completion)<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="costUsd">
        /// Estimated cost in USD<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgenticSearchTokenUsage(
            int? promptTokens,
            int? completionTokens,
            int? totalTokens,
            double? costUsd)
        {
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
            this.CostUsd = costUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticSearchTokenUsage" /> class.
        /// </summary>
        public AgenticSearchTokenUsage()
        {
        }
    }
}