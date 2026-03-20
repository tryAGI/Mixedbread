
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Supported regex flags.
    /// </summary>
    public enum RegexFlag
    {
        /// <summary>
        /// 
        /// </summary>
        Ignorecase,
        /// <summary>
        /// 
        /// </summary>
        Multiline,
        /// <summary>
        /// 
        /// </summary>
        Dotall,
        /// <summary>
        /// 
        /// </summary>
        Verbose,
        /// <summary>
        /// 
        /// </summary>
        Ascii,
        /// <summary>
        /// 
        /// </summary>
        Unicode,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RegexFlagExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RegexFlag value)
        {
            return value switch
            {
                RegexFlag.Ignorecase => "IGNORECASE",
                RegexFlag.Multiline => "MULTILINE",
                RegexFlag.Dotall => "DOTALL",
                RegexFlag.Verbose => "VERBOSE",
                RegexFlag.Ascii => "ASCII",
                RegexFlag.Unicode => "UNICODE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RegexFlag? ToEnum(string value)
        {
            return value switch
            {
                "IGNORECASE" => RegexFlag.Ignorecase,
                "MULTILINE" => RegexFlag.Multiline,
                "DOTALL" => RegexFlag.Dotall,
                "VERBOSE" => RegexFlag.Verbose,
                "ASCII" => RegexFlag.Ascii,
                "UNICODE" => RegexFlag.Unicode,
                _ => null,
            };
        }
    }
}