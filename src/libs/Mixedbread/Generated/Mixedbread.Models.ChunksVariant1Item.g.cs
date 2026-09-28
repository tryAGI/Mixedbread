#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mixedbread
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ChunksVariant1Item : global::System.IEquatable<ChunksVariant1Item>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.StoreFileChunksVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.TextInputChunk? Text { get; init; }
#else
        public global::Mixedbread.TextInputChunk? Text { get; }
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
            out global::Mixedbread.TextInputChunk? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.TextInputChunk PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.ImageUrlInputChunk? ImageUrl { get; init; }
#else
        public global::Mixedbread.ImageUrlInputChunk? ImageUrl { get; }
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
            out global::Mixedbread.ImageUrlInputChunk? value)
        {
            value = ImageUrl;
            return IsImageUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ImageUrlInputChunk PickImageUrl() => ImageUrl is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageUrl' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.AudioUrlInputChunk? AudioUrl { get; init; }
#else
        public global::Mixedbread.AudioUrlInputChunk? AudioUrl { get; }
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
            out global::Mixedbread.AudioUrlInputChunk? value)
        {
            value = AudioUrl;
            return IsAudioUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AudioUrlInputChunk PickAudioUrl() => AudioUrl is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioUrl' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.VideoUrlInputChunk? VideoUrl { get; init; }
#else
        public global::Mixedbread.VideoUrlInputChunk? VideoUrl { get; }
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
            out global::Mixedbread.VideoUrlInputChunk? value)
        {
            value = VideoUrl;
            return IsVideoUrl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VideoUrlInputChunk PickVideoUrl() => VideoUrl is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoUrl' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChunksVariant1Item(global::Mixedbread.TextInputChunk value) => new ChunksVariant1Item((global::Mixedbread.TextInputChunk?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Mixedbread.TextInputChunk?(ChunksVariant1Item @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ChunksVariant1Item(global::Mixedbread.TextInputChunk? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChunksVariant1Item FromText(global::Mixedbread.TextInputChunk? value) => new ChunksVariant1Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChunksVariant1Item(global::Mixedbread.ImageUrlInputChunk value) => new ChunksVariant1Item((global::Mixedbread.ImageUrlInputChunk?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Mixedbread.ImageUrlInputChunk?(ChunksVariant1Item @this) => @this.ImageUrl;

        /// <summary>
        ///
        /// </summary>
        public ChunksVariant1Item(global::Mixedbread.ImageUrlInputChunk? value)
        {
            ImageUrl = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChunksVariant1Item FromImageUrl(global::Mixedbread.ImageUrlInputChunk? value) => new ChunksVariant1Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChunksVariant1Item(global::Mixedbread.AudioUrlInputChunk value) => new ChunksVariant1Item((global::Mixedbread.AudioUrlInputChunk?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Mixedbread.AudioUrlInputChunk?(ChunksVariant1Item @this) => @this.AudioUrl;

        /// <summary>
        ///
        /// </summary>
        public ChunksVariant1Item(global::Mixedbread.AudioUrlInputChunk? value)
        {
            AudioUrl = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChunksVariant1Item FromAudioUrl(global::Mixedbread.AudioUrlInputChunk? value) => new ChunksVariant1Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChunksVariant1Item(global::Mixedbread.VideoUrlInputChunk value) => new ChunksVariant1Item((global::Mixedbread.VideoUrlInputChunk?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Mixedbread.VideoUrlInputChunk?(ChunksVariant1Item @this) => @this.VideoUrl;

        /// <summary>
        ///
        /// </summary>
        public ChunksVariant1Item(global::Mixedbread.VideoUrlInputChunk? value)
        {
            VideoUrl = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChunksVariant1Item FromVideoUrl(global::Mixedbread.VideoUrlInputChunk? value) => new ChunksVariant1Item(value);

        /// <summary>
        ///
        /// </summary>
        public ChunksVariant1Item(
            global::Mixedbread.StoreFileChunksVariant1ItemDiscriminatorType? type,
            global::Mixedbread.TextInputChunk? text,
            global::Mixedbread.ImageUrlInputChunk? imageUrl,
            global::Mixedbread.AudioUrlInputChunk? audioUrl,
            global::Mixedbread.VideoUrlInputChunk? videoUrl
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
            global::System.Func<global::Mixedbread.TextInputChunk, TResult>? text = null,
            global::System.Func<global::Mixedbread.ImageUrlInputChunk, TResult>? imageUrl = null,
            global::System.Func<global::Mixedbread.AudioUrlInputChunk, TResult>? audioUrl = null,
            global::System.Func<global::Mixedbread.VideoUrlInputChunk, TResult>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (ImageUrl is { } __value1 && imageUrl != null)
            {
                return imageUrl(__value1);
            }
            else if (AudioUrl is { } __value2 && audioUrl != null)
            {
                return audioUrl(__value2);
            }
            else if (VideoUrl is { } __value3 && videoUrl != null)
            {
                return videoUrl(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Mixedbread.TextInputChunk>? text = null,

            global::System.Action<global::Mixedbread.ImageUrlInputChunk>? imageUrl = null,

            global::System.Action<global::Mixedbread.AudioUrlInputChunk>? audioUrl = null,

            global::System.Action<global::Mixedbread.VideoUrlInputChunk>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (ImageUrl is { } __value1)
            {
                imageUrl?.Invoke(__value1);
            }
            else if (AudioUrl is { } __value2)
            {
                audioUrl?.Invoke(__value2);
            }
            else if (VideoUrl is { } __value3)
            {
                videoUrl?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Mixedbread.TextInputChunk>? text = null,
            global::System.Action<global::Mixedbread.ImageUrlInputChunk>? imageUrl = null,
            global::System.Action<global::Mixedbread.AudioUrlInputChunk>? audioUrl = null,
            global::System.Action<global::Mixedbread.VideoUrlInputChunk>? videoUrl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (ImageUrl is { } __value1)
            {
                imageUrl?.Invoke(__value1);
            }
            else if (AudioUrl is { } __value2)
            {
                audioUrl?.Invoke(__value2);
            }
            else if (VideoUrl is { } __value3)
            {
                videoUrl?.Invoke(__value3);
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
                typeof(global::Mixedbread.TextInputChunk),
                ImageUrl,
                typeof(global::Mixedbread.ImageUrlInputChunk),
                AudioUrl,
                typeof(global::Mixedbread.AudioUrlInputChunk),
                VideoUrl,
                typeof(global::Mixedbread.VideoUrlInputChunk),
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
        public bool Equals(ChunksVariant1Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.TextInputChunk?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.ImageUrlInputChunk?>.Default.Equals(ImageUrl, other.ImageUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.AudioUrlInputChunk?>.Default.Equals(AudioUrl, other.AudioUrl) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.VideoUrlInputChunk?>.Default.Equals(VideoUrl, other.VideoUrl)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ChunksVariant1Item obj1, ChunksVariant1Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChunksVariant1Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChunksVariant1Item obj1, ChunksVariant1Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChunksVariant1Item o && Equals(o);
        }
    }
}
