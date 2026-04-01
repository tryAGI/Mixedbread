#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public class Rule2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.Rule2>
    {
        /// <inheritdoc />
        public override global::Mixedbread.Rule2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mixedbread.QueryStringSubstitutionRule? queryString = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.QueryString)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.QueryStringSubstitutionRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.QueryStringSubstitutionRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.QueryStringSubstitutionRule)}");
                queryString = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.QueryRegexSubstitutionRule? queryRegex = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.QueryRegex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.QueryRegexSubstitutionRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.QueryRegexSubstitutionRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.QueryRegexSubstitutionRule)}");
                queryRegex = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.ChunkSearchResultRule? chunkSearchResult = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.ChunkSearchResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.ChunkSearchResultRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.ChunkSearchResultRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.ChunkSearchResultRule)}");
                chunkSearchResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.FileSearchResultRule? fileSearchResult = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniApiRoutesV1StoresRulesModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.FileSearchResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.FileSearchResultRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.FileSearchResultRule> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.FileSearchResultRule)}");
                fileSearchResult = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Mixedbread.Rule2(
                discriminator?.Type,
                queryString,

                queryRegex,

                chunkSearchResult,

                fileSearchResult
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.Rule2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsQueryString)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.QueryStringSubstitutionRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.QueryStringSubstitutionRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.QueryStringSubstitutionRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.QueryString!, typeInfo);
            }
            else if (value.IsQueryRegex)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.QueryRegexSubstitutionRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.QueryRegexSubstitutionRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.QueryRegexSubstitutionRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.QueryRegex!, typeInfo);
            }
            else if (value.IsChunkSearchResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.ChunkSearchResultRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.ChunkSearchResultRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.ChunkSearchResultRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChunkSearchResult!, typeInfo);
            }
            else if (value.IsFileSearchResult)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.FileSearchResultRule), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.FileSearchResultRule?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.FileSearchResultRule).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchResult!, typeInfo);
            }
        }
    }
}