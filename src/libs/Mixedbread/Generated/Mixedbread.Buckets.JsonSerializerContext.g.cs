
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Mixedbread
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.Bucket))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketProvider), TypeInfoPropertyName = "BucketProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketAuthType), TypeInfoPropertyName = "BucketAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketStatus), TypeInfoPropertyName = "BucketStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketAccessKeyCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketAssumeRoleCredentials))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketCreateParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.Credentials), TypeInfoPropertyName = "Credentials2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketCreateParamsCredentialsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketCreateParamsCredentialsDiscriminatorType), TypeInfoPropertyName = "BucketCreateParamsCredentialsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.CursorPaginationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.Bucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketRotateCredentialsParams))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketProvider?), TypeInfoPropertyName = "NullableBucketProvider2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketAuthType?), TypeInfoPropertyName = "NullableBucketAuthType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketStatus?), TypeInfoPropertyName = "NullableBucketStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.Credentials?), TypeInfoPropertyName = "NullableCredentials2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.BucketCreateParamsCredentialsDiscriminatorType?), TypeInfoPropertyName = "NullableBucketCreateParamsCredentialsDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Mixedbread.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.Bucket>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Mixedbread.AnyOf<string, int?>>))]
    internal sealed partial class BucketsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BucketsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BucketsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BucketsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Mixedbread.JsonConverters.CredentialsJsonConverter());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, int?, double?, bool?>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<string>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, object, global::System.Collections.Generic.IList<object>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::Mixedbread.AnyOf<string, bool?>>, object>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, bool?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<bool?, global::System.Collections.Generic.IList<int>>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.AnyOfJsonConverter<string, global::System.Guid?>());
            options.Converters.Add(new global::Mixedbread.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Mixedbread.BucketAuthType)

                    || typeToConvert == typeof(global::Mixedbread.BucketAuthType?)

                    || typeToConvert == typeof(global::Mixedbread.BucketCreateParamsCredentialsDiscriminatorType)

                    || typeToConvert == typeof(global::Mixedbread.BucketCreateParamsCredentialsDiscriminatorType?)

                    || typeToConvert == typeof(global::Mixedbread.BucketProvider)

                    || typeToConvert == typeof(global::Mixedbread.BucketProvider?)

                    || typeToConvert == typeof(global::Mixedbread.BucketStatus)

                    || typeToConvert == typeof(global::Mixedbread.BucketStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Mixedbread.BucketAuthType))
                {
                    return new global::Mixedbread.JsonConverters.BucketAuthTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.BucketAuthType?))
                {
                    return new global::Mixedbread.JsonConverters.BucketAuthTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.BucketCreateParamsCredentialsDiscriminatorType))
                {
                    return new global::Mixedbread.JsonConverters.BucketCreateParamsCredentialsDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.BucketCreateParamsCredentialsDiscriminatorType?))
                {
                    return new global::Mixedbread.JsonConverters.BucketCreateParamsCredentialsDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.BucketProvider))
                {
                    return new global::Mixedbread.JsonConverters.BucketProviderJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.BucketProvider?))
                {
                    return new global::Mixedbread.JsonConverters.BucketProviderNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.BucketStatus))
                {
                    return new global::Mixedbread.JsonConverters.BucketStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Mixedbread.BucketStatus?))
                {
                    return new global::Mixedbread.JsonConverters.BucketStatusNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new BucketsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}