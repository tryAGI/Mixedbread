#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Mixedbread
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct GeneratedMetadataVariant111 : global::System.IEquatable<GeneratedMetadataVariant111>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.MarkdownChunkGeneratedMetadata? Markdown { get; init; }
#else
        public global::Mixedbread.MarkdownChunkGeneratedMetadata? Markdown { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Markdown))]
#endif
        public bool IsMarkdown => Markdown != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMarkdown(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mixedbread.MarkdownChunkGeneratedMetadata? value)
        {
            value = Markdown;
            return IsMarkdown;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.MarkdownChunkGeneratedMetadata PickMarkdown() => Markdown is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Markdown' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.TextChunkGeneratedMetadata? Text { get; init; }
#else
        public global::Mixedbread.TextChunkGeneratedMetadata? Text { get; }
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
            out global::Mixedbread.TextChunkGeneratedMetadata? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.TextChunkGeneratedMetadata PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.PDFChunkGeneratedMetadata? Pdf { get; init; }
#else
        public global::Mixedbread.PDFChunkGeneratedMetadata? Pdf { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pdf))]
#endif
        public bool IsPdf => Pdf != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPdf(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mixedbread.PDFChunkGeneratedMetadata? value)
        {
            value = Pdf;
            return IsPdf;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.PDFChunkGeneratedMetadata PickPdf() => Pdf is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Pdf' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.CodeChunkGeneratedMetadata? Code { get; init; }
#else
        public global::Mixedbread.CodeChunkGeneratedMetadata? Code { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Code))]
#endif
        public bool IsCode => Code != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCode(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mixedbread.CodeChunkGeneratedMetadata? value)
        {
            value = Code;
            return IsCode;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.CodeChunkGeneratedMetadata PickCode() => Code is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Code' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.AudioChunkGeneratedMetadata? Audio { get; init; }
#else
        public global::Mixedbread.AudioChunkGeneratedMetadata? Audio { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Audio))]
#endif
        public bool IsAudio => Audio != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mixedbread.AudioChunkGeneratedMetadata? value)
        {
            value = Audio;
            return IsAudio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.AudioChunkGeneratedMetadata PickAudio() => Audio is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Audio' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.VideoChunkGeneratedMetadata? Video { get; init; }
#else
        public global::Mixedbread.VideoChunkGeneratedMetadata? Video { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Video))]
#endif
        public bool IsVideo => Video != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVideo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mixedbread.VideoChunkGeneratedMetadata? value)
        {
            value = Video;
            return IsVideo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.VideoChunkGeneratedMetadata PickVideo() => Video is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Video' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Mixedbread.ImageChunkGeneratedMetadata? Image { get; init; }
#else
        public global::Mixedbread.ImageChunkGeneratedMetadata? Image { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Mixedbread.ImageChunkGeneratedMetadata? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Mixedbread.ImageChunkGeneratedMetadata PickImage() => Image is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator GeneratedMetadataVariant111(global::Mixedbread.MarkdownChunkGeneratedMetadata value) => new GeneratedMetadataVariant111((global::Mixedbread.MarkdownChunkGeneratedMetadata?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Mixedbread.MarkdownChunkGeneratedMetadata?(GeneratedMetadataVariant111 @this) => @this.Markdown;

        /// <summary>
        ///
        /// </summary>
        public GeneratedMetadataVariant111(global::Mixedbread.MarkdownChunkGeneratedMetadata? value)
        {
            Markdown = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GeneratedMetadataVariant111 FromMarkdown(global::Mixedbread.MarkdownChunkGeneratedMetadata? value) => new GeneratedMetadataVariant111(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GeneratedMetadataVariant111(global::Mixedbread.TextChunkGeneratedMetadata value) => new GeneratedMetadataVariant111((global::Mixedbread.TextChunkGeneratedMetadata?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Mixedbread.TextChunkGeneratedMetadata?(GeneratedMetadataVariant111 @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public GeneratedMetadataVariant111(global::Mixedbread.TextChunkGeneratedMetadata? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GeneratedMetadataVariant111 FromText(global::Mixedbread.TextChunkGeneratedMetadata? value) => new GeneratedMetadataVariant111(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GeneratedMetadataVariant111(global::Mixedbread.PDFChunkGeneratedMetadata value) => new GeneratedMetadataVariant111((global::Mixedbread.PDFChunkGeneratedMetadata?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Mixedbread.PDFChunkGeneratedMetadata?(GeneratedMetadataVariant111 @this) => @this.Pdf;

        /// <summary>
        ///
        /// </summary>
        public GeneratedMetadataVariant111(global::Mixedbread.PDFChunkGeneratedMetadata? value)
        {
            Pdf = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GeneratedMetadataVariant111 FromPdf(global::Mixedbread.PDFChunkGeneratedMetadata? value) => new GeneratedMetadataVariant111(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GeneratedMetadataVariant111(global::Mixedbread.CodeChunkGeneratedMetadata value) => new GeneratedMetadataVariant111((global::Mixedbread.CodeChunkGeneratedMetadata?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Mixedbread.CodeChunkGeneratedMetadata?(GeneratedMetadataVariant111 @this) => @this.Code;

        /// <summary>
        ///
        /// </summary>
        public GeneratedMetadataVariant111(global::Mixedbread.CodeChunkGeneratedMetadata? value)
        {
            Code = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GeneratedMetadataVariant111 FromCode(global::Mixedbread.CodeChunkGeneratedMetadata? value) => new GeneratedMetadataVariant111(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GeneratedMetadataVariant111(global::Mixedbread.AudioChunkGeneratedMetadata value) => new GeneratedMetadataVariant111((global::Mixedbread.AudioChunkGeneratedMetadata?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Mixedbread.AudioChunkGeneratedMetadata?(GeneratedMetadataVariant111 @this) => @this.Audio;

        /// <summary>
        ///
        /// </summary>
        public GeneratedMetadataVariant111(global::Mixedbread.AudioChunkGeneratedMetadata? value)
        {
            Audio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GeneratedMetadataVariant111 FromAudio(global::Mixedbread.AudioChunkGeneratedMetadata? value) => new GeneratedMetadataVariant111(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GeneratedMetadataVariant111(global::Mixedbread.VideoChunkGeneratedMetadata value) => new GeneratedMetadataVariant111((global::Mixedbread.VideoChunkGeneratedMetadata?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Mixedbread.VideoChunkGeneratedMetadata?(GeneratedMetadataVariant111 @this) => @this.Video;

        /// <summary>
        ///
        /// </summary>
        public GeneratedMetadataVariant111(global::Mixedbread.VideoChunkGeneratedMetadata? value)
        {
            Video = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GeneratedMetadataVariant111 FromVideo(global::Mixedbread.VideoChunkGeneratedMetadata? value) => new GeneratedMetadataVariant111(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GeneratedMetadataVariant111(global::Mixedbread.ImageChunkGeneratedMetadata value) => new GeneratedMetadataVariant111((global::Mixedbread.ImageChunkGeneratedMetadata?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Mixedbread.ImageChunkGeneratedMetadata?(GeneratedMetadataVariant111 @this) => @this.Image;

        /// <summary>
        ///
        /// </summary>
        public GeneratedMetadataVariant111(global::Mixedbread.ImageChunkGeneratedMetadata? value)
        {
            Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GeneratedMetadataVariant111 FromImage(global::Mixedbread.ImageChunkGeneratedMetadata? value) => new GeneratedMetadataVariant111(value);

        /// <summary>
        ///
        /// </summary>
        public GeneratedMetadataVariant111(
            global::Mixedbread.MxbaiOmniCoreStoreModelsChunkTypesScoredTextInputChunkGeneratedMetadataVariant1DiscriminatorType? type,
            global::Mixedbread.MarkdownChunkGeneratedMetadata? markdown,
            global::Mixedbread.TextChunkGeneratedMetadata? text,
            global::Mixedbread.PDFChunkGeneratedMetadata? pdf,
            global::Mixedbread.CodeChunkGeneratedMetadata? code,
            global::Mixedbread.AudioChunkGeneratedMetadata? audio,
            global::Mixedbread.VideoChunkGeneratedMetadata? video,
            global::Mixedbread.ImageChunkGeneratedMetadata? image
            )
        {
            Type = type;

            Markdown = markdown;
            Text = text;
            Pdf = pdf;
            Code = code;
            Audio = audio;
            Video = video;
            Image = image;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Image as object ??
            Video as object ??
            Audio as object ??
            Code as object ??
            Pdf as object ??
            Text as object ??
            Markdown as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Markdown?.ToString() ??
            Text?.ToString() ??
            Pdf?.ToString() ??
            Code?.ToString() ??
            Audio?.ToString() ??
            Video?.ToString() ??
            Image?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMarkdown && !IsText && !IsPdf && !IsCode && !IsAudio && !IsVideo && !IsImage || !IsMarkdown && IsText && !IsPdf && !IsCode && !IsAudio && !IsVideo && !IsImage || !IsMarkdown && !IsText && IsPdf && !IsCode && !IsAudio && !IsVideo && !IsImage || !IsMarkdown && !IsText && !IsPdf && IsCode && !IsAudio && !IsVideo && !IsImage || !IsMarkdown && !IsText && !IsPdf && !IsCode && IsAudio && !IsVideo && !IsImage || !IsMarkdown && !IsText && !IsPdf && !IsCode && !IsAudio && IsVideo && !IsImage || !IsMarkdown && !IsText && !IsPdf && !IsCode && !IsAudio && !IsVideo && IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Mixedbread.MarkdownChunkGeneratedMetadata, TResult>? markdown = null,
            global::System.Func<global::Mixedbread.TextChunkGeneratedMetadata, TResult>? text = null,
            global::System.Func<global::Mixedbread.PDFChunkGeneratedMetadata, TResult>? pdf = null,
            global::System.Func<global::Mixedbread.CodeChunkGeneratedMetadata, TResult>? code = null,
            global::System.Func<global::Mixedbread.AudioChunkGeneratedMetadata, TResult>? audio = null,
            global::System.Func<global::Mixedbread.VideoChunkGeneratedMetadata, TResult>? video = null,
            global::System.Func<global::Mixedbread.ImageChunkGeneratedMetadata, TResult>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Markdown is { } __value0 && markdown != null)
            {
                return markdown(__value0);
            }
            else if (Text is { } __value1 && text != null)
            {
                return text(__value1);
            }
            else if (Pdf is { } __value2 && pdf != null)
            {
                return pdf(__value2);
            }
            else if (Code is { } __value3 && code != null)
            {
                return code(__value3);
            }
            else if (Audio is { } __value4 && audio != null)
            {
                return audio(__value4);
            }
            else if (Video is { } __value5 && video != null)
            {
                return video(__value5);
            }
            else if (Image is { } __value6 && image != null)
            {
                return image(__value6);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Mixedbread.MarkdownChunkGeneratedMetadata>? markdown = null,

            global::System.Action<global::Mixedbread.TextChunkGeneratedMetadata>? text = null,

            global::System.Action<global::Mixedbread.PDFChunkGeneratedMetadata>? pdf = null,

            global::System.Action<global::Mixedbread.CodeChunkGeneratedMetadata>? code = null,

            global::System.Action<global::Mixedbread.AudioChunkGeneratedMetadata>? audio = null,

            global::System.Action<global::Mixedbread.VideoChunkGeneratedMetadata>? video = null,

            global::System.Action<global::Mixedbread.ImageChunkGeneratedMetadata>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Markdown is { } __value0)
            {
                markdown?.Invoke(__value0);
            }
            else if (Text is { } __value1)
            {
                text?.Invoke(__value1);
            }
            else if (Pdf is { } __value2)
            {
                pdf?.Invoke(__value2);
            }
            else if (Code is { } __value3)
            {
                code?.Invoke(__value3);
            }
            else if (Audio is { } __value4)
            {
                audio?.Invoke(__value4);
            }
            else if (Video is { } __value5)
            {
                video?.Invoke(__value5);
            }
            else if (Image is { } __value6)
            {
                image?.Invoke(__value6);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Mixedbread.MarkdownChunkGeneratedMetadata>? markdown = null,
            global::System.Action<global::Mixedbread.TextChunkGeneratedMetadata>? text = null,
            global::System.Action<global::Mixedbread.PDFChunkGeneratedMetadata>? pdf = null,
            global::System.Action<global::Mixedbread.CodeChunkGeneratedMetadata>? code = null,
            global::System.Action<global::Mixedbread.AudioChunkGeneratedMetadata>? audio = null,
            global::System.Action<global::Mixedbread.VideoChunkGeneratedMetadata>? video = null,
            global::System.Action<global::Mixedbread.ImageChunkGeneratedMetadata>? image = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Markdown is { } __value0)
            {
                markdown?.Invoke(__value0);
            }
            else if (Text is { } __value1)
            {
                text?.Invoke(__value1);
            }
            else if (Pdf is { } __value2)
            {
                pdf?.Invoke(__value2);
            }
            else if (Code is { } __value3)
            {
                code?.Invoke(__value3);
            }
            else if (Audio is { } __value4)
            {
                audio?.Invoke(__value4);
            }
            else if (Video is { } __value5)
            {
                video?.Invoke(__value5);
            }
            else if (Image is { } __value6)
            {
                image?.Invoke(__value6);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Markdown,
                typeof(global::Mixedbread.MarkdownChunkGeneratedMetadata),
                Text,
                typeof(global::Mixedbread.TextChunkGeneratedMetadata),
                Pdf,
                typeof(global::Mixedbread.PDFChunkGeneratedMetadata),
                Code,
                typeof(global::Mixedbread.CodeChunkGeneratedMetadata),
                Audio,
                typeof(global::Mixedbread.AudioChunkGeneratedMetadata),
                Video,
                typeof(global::Mixedbread.VideoChunkGeneratedMetadata),
                Image,
                typeof(global::Mixedbread.ImageChunkGeneratedMetadata),
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
        public bool Equals(GeneratedMetadataVariant111 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.MarkdownChunkGeneratedMetadata?>.Default.Equals(Markdown, other.Markdown) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.TextChunkGeneratedMetadata?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.PDFChunkGeneratedMetadata?>.Default.Equals(Pdf, other.Pdf) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.CodeChunkGeneratedMetadata?>.Default.Equals(Code, other.Code) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.AudioChunkGeneratedMetadata?>.Default.Equals(Audio, other.Audio) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.VideoChunkGeneratedMetadata?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::Mixedbread.ImageChunkGeneratedMetadata?>.Default.Equals(Image, other.Image)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(GeneratedMetadataVariant111 obj1, GeneratedMetadataVariant111 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GeneratedMetadataVariant111>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GeneratedMetadataVariant111 obj1, GeneratedMetadataVariant111 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GeneratedMetadataVariant111 o && Equals(o);
        }
    }
}
