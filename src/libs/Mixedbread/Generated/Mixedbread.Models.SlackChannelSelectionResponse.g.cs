
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Slack channel selection response.
    /// </summary>
    public sealed partial class SlackChannelSelectionResponse
    {
        /// <summary>
        /// Slack channel selection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mixedbread.SlackChannelSelection Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackChannelSelectionResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Slack channel selection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlackChannelSelectionResponse(
            global::Mixedbread.SlackChannelSelection data)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackChannelSelectionResponse" /> class.
        /// </summary>
        public SlackChannelSelectionResponse()
        {
        }

    }
}