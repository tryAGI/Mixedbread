
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Request body for connecting Slack with a customer-provided app (bot token + signing secret).
    /// </summary>
    public sealed partial class SlackManualConnectBody
    {
        /// <summary>
        /// Slack bot user OAuth token (xoxb-…)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bot_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BotToken { get; set; }

        /// <summary>
        /// Slack app signing secret
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signing_secret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SigningSecret { get; set; }

        /// <summary>
        /// Optional ingestion store name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("store_name")]
        public string? StoreName { get; set; }

        /// <summary>
        /// Automatically sync all current and future channels<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_sync_all")]
        public bool? AutoSyncAll { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackManualConnectBody" /> class.
        /// </summary>
        /// <param name="botToken">
        /// Slack bot user OAuth token (xoxb-…)
        /// </param>
        /// <param name="signingSecret">
        /// Slack app signing secret
        /// </param>
        /// <param name="storeName">
        /// Optional ingestion store name
        /// </param>
        /// <param name="autoSyncAll">
        /// Automatically sync all current and future channels<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SlackManualConnectBody(
            string botToken,
            string signingSecret,
            string? storeName,
            bool? autoSyncAll)
        {
            this.BotToken = botToken ?? throw new global::System.ArgumentNullException(nameof(botToken));
            this.SigningSecret = signingSecret ?? throw new global::System.ArgumentNullException(nameof(signingSecret));
            this.StoreName = storeName;
            this.AutoSyncAll = autoSyncAll;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SlackManualConnectBody" /> class.
        /// </summary>
        public SlackManualConnectBody()
        {
        }

    }
}