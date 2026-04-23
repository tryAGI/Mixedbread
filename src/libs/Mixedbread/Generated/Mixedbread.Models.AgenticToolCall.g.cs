
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Represents a single tool call made by the agent during an agentic search.<br/>
    /// Fields follow the OpenTelemetry GenAI semantic conventions for tool calls:<br/>
    /// https://opentelemetry.io/docs/specs/semconv/gen-ai/gen-ai-spans/
    /// </summary>
    public sealed partial class AgenticToolCall
    {
        /// <summary>
        /// Unique identifier for the tool call (gen_ai.tool.call.id)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolCallId { get; set; }

        /// <summary>
        /// Name of the tool invoked (gen_ai.tool.name)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ToolName { get; set; }

        /// <summary>
        /// Category of the tool (gen_ai.tool.type)<br/>
        /// Default Value: function
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.AgenticToolCallToolTypeJsonConverter))]
        public global::Mixedbread.AgenticToolCallToolType? ToolType { get; set; }

        /// <summary>
        /// Time when the tool call began
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartedAt { get; set; }

        /// <summary>
        /// Time taken to execute the tool call
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Duration { get; set; }

        /// <summary>
        /// Arguments passed to the tool (gen_ai.tool.call.arguments)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Arguments { get; set; }

        /// <summary>
        /// Result returned to the model (gen_ai.tool.call.result). None if the tool errored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        public object? Result { get; set; }

        /// <summary>
        /// Error message if the tool call failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticToolCall" /> class.
        /// </summary>
        /// <param name="toolCallId">
        /// Unique identifier for the tool call (gen_ai.tool.call.id)
        /// </param>
        /// <param name="toolName">
        /// Name of the tool invoked (gen_ai.tool.name)
        /// </param>
        /// <param name="startedAt">
        /// Time when the tool call began
        /// </param>
        /// <param name="duration">
        /// Time taken to execute the tool call
        /// </param>
        /// <param name="arguments">
        /// Arguments passed to the tool (gen_ai.tool.call.arguments)
        /// </param>
        /// <param name="toolType">
        /// Category of the tool (gen_ai.tool.type)<br/>
        /// Default Value: function
        /// </param>
        /// <param name="result">
        /// Result returned to the model (gen_ai.tool.call.result). None if the tool errored.
        /// </param>
        /// <param name="error">
        /// Error message if the tool call failed
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgenticToolCall(
            string toolCallId,
            string toolName,
            global::System.DateTime startedAt,
            string duration,
            object arguments,
            global::Mixedbread.AgenticToolCallToolType? toolType,
            object? result,
            string? error)
        {
            this.ToolCallId = toolCallId ?? throw new global::System.ArgumentNullException(nameof(toolCallId));
            this.ToolName = toolName ?? throw new global::System.ArgumentNullException(nameof(toolName));
            this.ToolType = toolType;
            this.StartedAt = startedAt;
            this.Duration = duration ?? throw new global::System.ArgumentNullException(nameof(duration));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Result = result;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgenticToolCall" /> class.
        /// </summary>
        public AgenticToolCall()
        {
        }
    }
}