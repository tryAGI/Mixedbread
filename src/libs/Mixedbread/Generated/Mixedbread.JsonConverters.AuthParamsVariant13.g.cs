#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public class AuthParamsVariant13JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.AuthParamsVariant13>
    {
        /// <inheritdoc />
        public override global::Mixedbread.AuthParamsVariant13 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator>(ref readerCopy, options);

            global::Mixedbread.OAuth2CreateOrUpdateParams? oauth2 = default;
            if (discriminator?.Type == global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType.Oauth2)
            {
                oauth2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.OAuth2CreateOrUpdateParams>(ref reader, options);
            }
            global::Mixedbread.ApiKeyCreateOrUpdateParams? apiKey = default;
            if (discriminator?.Type == global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType.ApiKey)
            {
                apiKey = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.ApiKeyCreateOrUpdateParams>(ref reader, options);
            }

            var __value = new global::Mixedbread.AuthParamsVariant13(
                discriminator?.Type,
                oauth2,

                apiKey
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.AuthParamsVariant13 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsOauth2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2, typeof(global::Mixedbread.OAuth2CreateOrUpdateParams), options);
            }
            else if (value.IsApiKey)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKey, typeof(global::Mixedbread.ApiKeyCreateOrUpdateParams), options);
            }
        }
    }
}