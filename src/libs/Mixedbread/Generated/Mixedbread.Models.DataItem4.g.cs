#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DataItem4 : global::System.IEquatable<DataItem4>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminatorType? Type { get; }

        /// <summary>
        /// Scored text chunk for deprecated API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk? Text { get; init; }
#else
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        /// Scored image chunk for deprecated API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk? ImageUrl { get; init; }
#else
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk? ImageUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUrl))]
#endif
        public bool IsImageUrl => ImageUrl != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickImageUrl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk? value)
        {
            value = ImageUrl;
            return IsImageUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk PickImageUrl() => IsImageUrl
            ? ImageUrl!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageUrl' but the value was {ToString()}.");

        /// <summary>
        /// Scored audio chunk for deprecated API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk? AudioUrl { get; init; }
#else
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk? AudioUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioUrl))]
#endif
        public bool IsAudioUrl => AudioUrl != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAudioUrl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk? value)
        {
            value = AudioUrl;
            return IsAudioUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk PickAudioUrl() => IsAudioUrl
            ? AudioUrl!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioUrl' but the value was {ToString()}.");

        /// <summary>
        /// Scored video chunk for deprecated API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk? VideoUrl { get; init; }
#else
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk? VideoUrl { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoUrl))]
#endif
        public bool IsVideoUrl => VideoUrl != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVideoUrl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk? value)
        {
            value = VideoUrl;
            return IsVideoUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk PickVideoUrl() => IsVideoUrl
            ? VideoUrl!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoUrl' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem4(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk value) => new DataItem4((global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk?(DataItem4 @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public DataItem4(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DataItem4 FromText(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk? value) => new DataItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem4(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk value) => new DataItem4((global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk?(DataItem4 @this) => @this.ImageUrl;

        /// <summary>
        /// 
        /// </summary>
        public DataItem4(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DataItem4 FromImageUrl(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk? value) => new DataItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem4(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk value) => new DataItem4((global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk?(DataItem4 @this) => @this.AudioUrl;

        /// <summary>
        /// 
        /// </summary>
        public DataItem4(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk? value)
        {
            AudioUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DataItem4 FromAudioUrl(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk? value) => new DataItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DataItem4(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk value) => new DataItem4((global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk?(DataItem4 @this) => @this.VideoUrl;

        /// <summary>
        /// 
        /// </summary>
        public DataItem4(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk? value)
        {
            VideoUrl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DataItem4 FromVideoUrl(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk? value) => new DataItem4(value);

        /// <summary>
        /// 
        /// </summary>
        public DataItem4(
            global::Mixedbread.VectorStoreSearchResponseDataItemDiscriminatorType? type,
            global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk? text,
            global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk? imageUrl,
            global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk? audioUrl,
            global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk? videoUrl
            )
        {
            Type = type;

            Text = text;
            ImageUrl = imageUrl;
            AudioUrl = audioUrl;
            VideoUrl = videoUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            VideoUrl as object ??
            AudioUrl as object ??
            ImageUrl as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ImageUrl?.ToString() ??
            AudioUrl?.ToString() ??
            VideoUrl?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImageUrl && !IsAudioUrl && !IsVideoUrl || !IsText && IsImageUrl && !IsAudioUrl && !IsVideoUrl || !IsText && !IsImageUrl && IsAudioUrl && !IsVideoUrl || !IsText && !IsImageUrl && !IsAudioUrl && IsVideoUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk, TResult>? text = null,
            global::System.Func<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk, TResult>? imageUrl = null,
            global::System.Func<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk, TResult>? audioUrl = null,
            global::System.Func<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk, TResult>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsImageUrl && imageUrl != null)
            {
                return imageUrl(ImageUrl!);
            }
            else if (IsAudioUrl && audioUrl != null)
            {
                return audioUrl(AudioUrl!);
            }
            else if (IsVideoUrl && videoUrl != null)
            {
                return videoUrl(VideoUrl!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk>? text = null,

            global::System.Action<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk>? imageUrl = null,

            global::System.Action<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk>? audioUrl = null,

            global::System.Action<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
            else if (IsAudioUrl)
            {
                audioUrl?.Invoke(AudioUrl!);
            }
            else if (IsVideoUrl)
            {
                videoUrl?.Invoke(VideoUrl!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk>? text = null,
            global::System.Action<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk>? imageUrl = null,
            global::System.Action<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk>? audioUrl = null,
            global::System.Action<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImageUrl)
            {
                imageUrl?.Invoke(ImageUrl!);
            }
            else if (IsAudioUrl)
            {
                audioUrl?.Invoke(AudioUrl!);
            }
            else if (IsVideoUrl)
            {
                videoUrl?.Invoke(VideoUrl!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk),
                ImageUrl,
                typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk),
                AudioUrl,
                typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk),
                VideoUrl,
                typeof(global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(DataItem4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredTextInputChunk?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredImageUrlInputChunk?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredAudioUrlInputChunk?>.Default.Equals(AudioUrl, other.AudioUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.MxbaiOmniApiRoutesV1DeprecatedVectorStoresModelsScoredVideoUrlInputChunk?>.Default.Equals(VideoUrl, other.VideoUrl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DataItem4 obj1, DataItem4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DataItem4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DataItem4 obj1, DataItem4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DataItem4 o && Equals(o);
        }
    }
}
