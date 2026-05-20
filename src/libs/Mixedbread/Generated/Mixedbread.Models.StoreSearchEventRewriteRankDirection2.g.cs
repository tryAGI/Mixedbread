
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// 
    /// </summary>
    public enum StoreSearchEventRewriteRankDirection2
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StoreSearchEventRewriteRankDirection2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreSearchEventRewriteRankDirection2 value)
        {
            return value switch
            {
                StoreSearchEventRewriteRankDirection2.Asc => "asc",
                StoreSearchEventRewriteRankDirection2.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreSearchEventRewriteRankDirection2? ToEnum(string value)
        {
            return value switch
            {
                "asc" => StoreSearchEventRewriteRankDirection2.Asc,
                "desc" => StoreSearchEventRewriteRankDirection2.Desc,
                _ => null,
            };
        }
    }
}