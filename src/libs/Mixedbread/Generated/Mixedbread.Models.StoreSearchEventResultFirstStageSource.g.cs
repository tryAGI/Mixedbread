
#nullable enable

namespace Mixedbread
{
    /// <summary>
    ///
    /// </summary>
    public enum StoreSearchEventResultFirstStageSource
    {
        /// <summary>
        ///
        /// </summary>
        Both,
        /// <summary>
        ///
        /// </summary>
        Dense,
        /// <summary>
        ///
        /// </summary>
        Sparse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StoreSearchEventResultFirstStageSourceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StoreSearchEventResultFirstStageSource value)
        {
            return value switch
            {
                StoreSearchEventResultFirstStageSource.Both => "both",
                StoreSearchEventResultFirstStageSource.Dense => "dense",
                StoreSearchEventResultFirstStageSource.Sparse => "sparse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StoreSearchEventResultFirstStageSource? ToEnum(string value)
        {
            return value switch
            {
                "both" => StoreSearchEventResultFirstStageSource.Both,
                "dense" => StoreSearchEventResultFirstStageSource.Dense,
                "sparse" => StoreSearchEventResultFirstStageSource.Sparse,
                _ => null,
            };
        }
    }
}