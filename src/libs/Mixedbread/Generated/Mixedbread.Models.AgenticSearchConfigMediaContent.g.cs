
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Controls when retrieved image content is provided to the agent. `auto` sends images only when no OCR text or summary is available, `never` disables image content, and `always` sends image content when available.<br/>
    /// Default Value: auto
    /// </summary>
    public enum AgenticSearchConfigMediaContent
    {
        /// <summary>
        /// 
        /// </summary>
        Always,
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        Never,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgenticSearchConfigMediaContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgenticSearchConfigMediaContent value)
        {
            return value switch
            {
                AgenticSearchConfigMediaContent.Always => "always",
                AgenticSearchConfigMediaContent.Auto => "auto",
                AgenticSearchConfigMediaContent.Never => "never",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgenticSearchConfigMediaContent? ToEnum(string value)
        {
            return value switch
            {
                "always" => AgenticSearchConfigMediaContent.Always,
                "auto" => AgenticSearchConfigMediaContent.Auto,
                "never" => AgenticSearchConfigMediaContent.Never,
                _ => null,
            };
        }
    }
}