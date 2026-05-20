
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public enum StoreSearchEventRewriteRankMode2
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
    public static class StoreSearchEventRewriteRankMode2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreSearchEventRewriteRankMode2 value)
        {
            return value switch
            {
                StoreSearchEventRewriteRankMode2.Metadata => "metadata",
                StoreSearchEventRewriteRankMode2.PostSearch => "post_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreSearchEventRewriteRankMode2? ToEnum(string value)
        {
            return value switch
            {
                "metadata" => StoreSearchEventRewriteRankMode2.Metadata,
                "post_search" => StoreSearchEventRewriteRankMode2.PostSearch,
                _ => null,
            };
        }
    }
}