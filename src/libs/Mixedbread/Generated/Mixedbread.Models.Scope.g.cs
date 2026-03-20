
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Scope
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.ScopeMethodJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Mixedbread.ScopeMethod Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        public string? ResourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?, object>))]
        public global::Mixedbread.AnyOf<string, global::System.Guid?, object>? ResourceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Scope" /> class.
        /// </summary>
        /// <param name="method"></param>
        /// <param name="resourceType"></param>
        /// <param name="resourceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Scope(
            global::Mixedbread.ScopeMethod method,
            string? resourceType,
            global::Mixedbread.AnyOf<string, global::System.Guid?, object>? resourceId)
        {
            this.Method = method;
            this.ResourceType = resourceType;
            this.ResourceId = resourceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Scope" /> class.
        /// </summary>
        public Scope()
        {
        }
    }
}