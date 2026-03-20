#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public class MultiModalQueryVariant2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.MultiModalQueryVariant2>
    {
        /// <inheritdoc />
        public override global::Mixedbread.MultiModalQueryVariant2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.MultiModalQueryVariant2Discriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.MultiModalQueryVariant2Discriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.MultiModalQueryVariant2Discriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mixedbread.ImageUrlInput2? imageUrl = default;
            if (discriminator?.Type == global::Mixedbread.MultiModalQueryVariant2DiscriminatorType.ImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.ImageUrlInput2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.ImageUrlInput2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.ImageUrlInput2)}");
                imageUrl = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.TextInput? text = default;
            if (discriminator?.Type == global::Mixedbread.MultiModalQueryVariant2DiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.TextInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.TextInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.TextInput)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Mixedbread.MultiModalQueryVariant2(
                discriminator?.Type,
                imageUrl,

                text
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.MultiModalQueryVariant2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsImageUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.ImageUrlInput2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.ImageUrlInput2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.ImageUrlInput2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.ImageUrl, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.TextInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.TextInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.TextInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
        }
    }
}