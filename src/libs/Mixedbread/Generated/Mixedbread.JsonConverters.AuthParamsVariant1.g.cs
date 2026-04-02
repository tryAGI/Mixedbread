#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public class AuthParamsVariant1JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.AuthParamsVariant1>
    {
        /// <inheritdoc />
        public override global::Mixedbread.AuthParamsVariant1 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.DataSourceAuthParamsVariant1Discriminator>(ref readerCopy, options);

            global::Mixedbread.DataSourceOAuth2Params? oauth2 = default;
            if (discriminator?.Type == global::Mixedbread.DataSourceAuthParamsVariant1DiscriminatorType.Oauth2)
            {
                oauth2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.DataSourceOAuth2Params>(ref reader, options);
            }
            global::Mixedbread.DataSourceApiKeyParams? apiKey = default;
            if (discriminator?.Type == global::Mixedbread.DataSourceAuthParamsVariant1DiscriminatorType.ApiKey)
            {
                apiKey = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.DataSourceApiKeyParams>(ref reader, options);
            }

            var __value = new global::Mixedbread.AuthParamsVariant1(
                discriminator?.Type,
                oauth2,

                apiKey
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.AuthParamsVariant1 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsOauth2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2, typeof(global::Mixedbread.DataSourceOAuth2Params), options);
            }
            else if (value.IsApiKey)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKey, typeof(global::Mixedbread.DataSourceApiKeyParams), options);
            }
        }
    }
}