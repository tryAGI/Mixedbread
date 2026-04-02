#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public class RuleJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.Rule>
    {
        /// <inheritdoc />
        public override global::Mixedbread.Rule Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminator>(ref readerCopy, options);

            global::Mixedbread.QueryStringSubstitutionRule? queryString = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.QueryString)
            {
                queryString = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.QueryStringSubstitutionRule>(ref reader, options);
            }
            global::Mixedbread.QueryRegexSubstitutionRule? queryRegex = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.QueryRegex)
            {
                queryRegex = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.QueryRegexSubstitutionRule>(ref reader, options);
            }
            global::Mixedbread.ChunkSearchResultRule? chunkSearchResult = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.ChunkSearchResult)
            {
                chunkSearchResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.ChunkSearchResultRule>(ref reader, options);
            }
            global::Mixedbread.FileSearchResultRule? fileSearchResult = default;
            if (discriminator?.Type == global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsSearchRuleSpecificDeleteParamsRuleDiscriminatorType.FileSearchResult)
            {
                fileSearchResult = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.FileSearchResultRule>(ref reader, options);
            }

            var __value = new global::Mixedbread.Rule(
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
            global::Mixedbread.Rule value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsQueryString)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.QueryString, typeof(global::Mixedbread.QueryStringSubstitutionRule), options);
            }
            else if (value.IsQueryRegex)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.QueryRegex, typeof(global::Mixedbread.QueryRegexSubstitutionRule), options);
            }
            else if (value.IsChunkSearchResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ChunkSearchResult, typeof(global::Mixedbread.ChunkSearchResultRule), options);
            }
            else if (value.IsFileSearchResult)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.FileSearchResult, typeof(global::Mixedbread.FileSearchResultRule), options);
            }
        }
    }
}