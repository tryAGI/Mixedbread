
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Rendered Slack app manifest for bring-your-own-app setup.
    /// </summary>
    public sealed partial class SlackManifestResponse
    {
        /// <summary>
        /// Slack app manifest YAML pre-filled with this deployment's URLs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Manifest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackManifestResponse" /> class.
        /// </summary>
        /// <param name="manifest">
        /// Slack app manifest YAML pre-filled with this deployment's URLs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlackManifestResponse(
            string manifest)
        {
            this.Manifest = manifest ?? throw new global::System.ArgumentNullException(nameof(manifest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackManifestResponse" /> class.
        /// </summary>
        public SlackManifestResponse()
        {
        }

    }
}