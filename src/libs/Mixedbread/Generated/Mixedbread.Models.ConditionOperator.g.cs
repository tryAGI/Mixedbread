
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Operator for a filter condition.
    /// </summary>
    public enum ConditionOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        NotEq,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
        In,
        /// <summary>
        /// 
        /// </summary>
        NotIn,
        /// <summary>
        /// 
        /// </summary>
        Like,
        /// <summary>
        /// 
        /// </summary>
        StartsWith,
        /// <summary>
        /// 
        /// </summary>
        NotLike,
        /// <summary>
        /// 
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConditionOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConditionOperator value)
        {
            return value switch
            {
                ConditionOperator.Eq => "eq",
                ConditionOperator.NotEq => "not_eq",
                ConditionOperator.Gt => "gt",
                ConditionOperator.Gte => "gte",
                ConditionOperator.Lt => "lt",
                ConditionOperator.Lte => "lte",
                ConditionOperator.In => "in",
                ConditionOperator.NotIn => "not_in",
                ConditionOperator.Like => "like",
                ConditionOperator.StartsWith => "starts_with",
                ConditionOperator.NotLike => "not_like",
                ConditionOperator.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConditionOperator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => ConditionOperator.Eq,
                "not_eq" => ConditionOperator.NotEq,
                "gt" => ConditionOperator.Gt,
                "gte" => ConditionOperator.Gte,
                "lt" => ConditionOperator.Lt,
                "lte" => ConditionOperator.Lte,
                "in" => ConditionOperator.In,
                "not_in" => ConditionOperator.NotIn,
                "like" => ConditionOperator.Like,
                "starts_with" => ConditionOperator.StartsWith,
                "not_like" => ConditionOperator.NotLike,
                "regex" => ConditionOperator.Regex,
                _ => null,
            };
        }
    }
}