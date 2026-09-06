
#nullable enable

namespace Mixedbread
{
    /// <summary>
    ///
    /// </summary>
    public enum StoreSearchEventRewriteRankDirection
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
    public static class StoreSearchEventRewriteRankDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreSearchEventRewriteRankDirection value)
        {
            return value switch
            {
                StoreSearchEventRewriteRankDirection.Asc => "asc",
                StoreSearchEventRewriteRankDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreSearchEventRewriteRankDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => StoreSearchEventRewriteRankDirection.Asc,
                "desc" => StoreSearchEventRewriteRankDirection.Desc,
                _ => null,
            };
        }
    }
}