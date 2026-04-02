#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public class AuthParamsVariant12JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.AuthParamsVariant12>
    {
        /// <inheritdoc />
        public override global::Mixedbread.AuthParamsVariant12 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator>(ref readerCopy, options);

            global::Mixedbread.OAuth2CreateOrUpdateParams? oauth2 = default;
            if (discriminator?.Type == global::Mixedbread.LinearDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType.Oauth2)
            {
                oauth2 = global::System.Text.Json.JsonSerializer.Deserialize<global::Mixedbread.OAuth2CreateOrUpdateParams>(ref reader, options);
            }

            var __value = new global::Mixedbread.AuthParamsVariant12(
                discriminator?.Type,
                oauth2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.AuthParamsVariant12 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsOauth2)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2, typeof(global::Mixedbread.OAuth2CreateOrUpdateParams), options);
            }
        }
    }
}