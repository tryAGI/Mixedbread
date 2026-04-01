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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mixedbread.OAuth2CreateOrUpdateParams? oauth2 = default;
            if (discriminator?.Type == global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType.Oauth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.OAuth2CreateOrUpdateParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.OAuth2CreateOrUpdateParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.OAuth2CreateOrUpdateParams)}");
                oauth2 = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.ApiKeyCreateOrUpdateParams? apiKey = default;
            if (discriminator?.Type == global::Mixedbread.NotionDataSourceCreateOrUpdateParamsAuthParamsVariant1DiscriminatorType.ApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.ApiKeyCreateOrUpdateParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.ApiKeyCreateOrUpdateParams> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.ApiKeyCreateOrUpdateParams)}");
                apiKey = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOauth2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.OAuth2CreateOrUpdateParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.OAuth2CreateOrUpdateParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.OAuth2CreateOrUpdateParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Oauth2!, typeInfo);
            }
            else if (value.IsApiKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.ApiKeyCreateOrUpdateParams), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.ApiKeyCreateOrUpdateParams?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.ApiKeyCreateOrUpdateParams).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ApiKey!, typeInfo);
            }
        }
    }
}