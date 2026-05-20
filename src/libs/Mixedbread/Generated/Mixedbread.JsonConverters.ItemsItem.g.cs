#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Mixedbread.JsonConverters
{
    /// <inheritdoc />
    public class ItemsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Mixedbread.ItemsItem>
    {
        /// <inheritdoc />
        public override global::Mixedbread.ItemsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.QueryEnhanceResultsItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.QueryEnhanceResultsItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.QueryEnhanceResultsItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Mixedbread.QueryEnhanceQueryItem? query = default;
            if (discriminator?.Type == global::Mixedbread.QueryEnhanceResultsItemDiscriminatorType.Query)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.QueryEnhanceQueryItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.QueryEnhanceQueryItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.QueryEnhanceQueryItem)}");
                query = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Mixedbread.QueryEnhanceSortItem? sort = default;
            if (discriminator?.Type == global::Mixedbread.QueryEnhanceResultsItemDiscriminatorType.Sort)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.QueryEnhanceSortItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.QueryEnhanceSortItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Mixedbread.QueryEnhanceSortItem)}");
                sort = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Mixedbread.ItemsItem(
                discriminator?.Type,
                query,

                sort
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Mixedbread.ItemsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsQuery)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.QueryEnhanceQueryItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.QueryEnhanceQueryItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.QueryEnhanceQueryItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Query!, typeInfo);
            }
            else if (value.IsSort)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Mixedbread.QueryEnhanceSortItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Mixedbread.QueryEnhanceSortItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Mixedbread.QueryEnhanceSortItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sort!, typeInfo);
            }
        }
    }
}