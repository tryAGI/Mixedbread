
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Category of the tool (gen_ai.tool.type)<br/>
    /// Default Value: function
    /// </summary>
    public enum AgenticToolCallToolType
    {
        /// <summary>
        /// 
        /// </summary>
        Datastore,
        /// <summary>
        /// 
        /// </summary>
        Extension,
        /// <summary>
        /// 
        /// </summary>
        Function,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgenticToolCallToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgenticToolCallToolType value)
        {
            return value switch
            {
                AgenticToolCallToolType.Datastore => "datastore",
                AgenticToolCallToolType.Extension => "extension",
                AgenticToolCallToolType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgenticToolCallToolType? ToEnum(string value)
        {
            return value switch
            {
                "datastore" => AgenticToolCallToolType.Datastore,
                "extension" => AgenticToolCallToolType.Extension,
                "function" => AgenticToolCallToolType.Function,
                _ => null,
            };
        }
    }
}