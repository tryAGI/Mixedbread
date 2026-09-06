
#nullable enable

namespace Mixedbread
{
    /// <summary>
    ///
    /// </summary>
    public enum StoreSearchEventRewriteRankMode
    {
        /// <summary>
        ///
        /// </summary>
        Metadata,
        /// <summary>
        ///
        /// </summary>
        PostSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StoreSearchEventRewriteRankModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreSearchEventRewriteRankMode value)
        {
            return value switch
            {
                StoreSearchEventRewriteRankMode.Metadata => "metadata",
                StoreSearchEventRewriteRankMode.PostSearch => "post_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreSearchEventRewriteRankMode? ToEnum(string value)
        {
            return value switch
            {
                "metadata" => StoreSearchEventRewriteRankMode.Metadata,
                "post_search" => StoreSearchEventRewriteRankMode.PostSearch,
                _ => null,
            };
        }
    }
}