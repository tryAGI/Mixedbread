#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public class CredentialsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.Credentials>
    {
        /// <inheritdoc />
        public override global::Mixedbread.Credentials Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.BucketCreateParamsCredentialsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.BucketCreateParamsCredentialsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.BucketCreateParamsCredentialsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mixedbread.BucketAssumeRoleCredentials? assumeRole = default;
            if (discriminator?.Type == global::Mixedbread.BucketCreateParamsCredentialsDiscriminatorType.AssumeRole)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.BucketAssumeRoleCredentials), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.BucketAssumeRoleCredentials> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.BucketAssumeRoleCredentials)}");
                assumeRole = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.BucketAccessKeyCredentials? accessKey = default;
            if (discriminator?.Type == global::Mixedbread.BucketCreateParamsCredentialsDiscriminatorType.AccessKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.BucketAccessKeyCredentials), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.BucketAccessKeyCredentials> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.BucketAccessKeyCredentials)}");
                accessKey = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Mixedbread.Credentials(
                discriminator?.Type,
                assumeRole,

                accessKey
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.Credentials value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsAssumeRole)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.BucketAssumeRoleCredentials), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.BucketAssumeRoleCredentials?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.BucketAssumeRoleCredentials).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AssumeRole!, typeInfo);
            }
            else if (value.IsAccessKey)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.BucketAccessKeyCredentials), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.BucketAccessKeyCredentials?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.BucketAccessKeyCredentials).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AccessKey!, typeInfo);
            }
        }
    }
}