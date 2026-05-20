
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Logical chunk content groups the grep tool can match against.<br/>
    /// These map to one or more underlying chunk fields:<br/>
    /// - ``text``      → text chunks' ``text`` field (original text content).<br/>
    /// - ``generated`` → fields produced during ingestion (``transcription`` for audio/video,<br/>
    ///   ``ocr_text`` for images, and ``summary`` across modalities).
    /// </summary>
    public enum StoreChunkGrepTarget
    {
        /// <summary>
        /// 
        /// </summary>
        Generated,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StoreChunkGrepTargetExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreChunkGrepTarget value)
        {
            return value switch
            {
                StoreChunkGrepTarget.Generated => "generated",
                StoreChunkGrepTarget.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreChunkGrepTarget? ToEnum(string value)
        {
            return value switch
            {
                "generated" => StoreChunkGrepTarget.Generated,
                "text" => StoreChunkGrepTarget.Text,
                _ => null,
            };
        }
    }
}