
#nullable enable

namespace Mixedbread
{
    /// <summary>
    /// Types of elements that can be extracted from a document.
    /// </summary>
    public enum ElementType
    {
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        Footer,
        /// <summary>
        /// 
        /// </summary>
        Title,
        /// <summary>
        /// 
        /// </summary>
        SectionHeader,
        /// <summary>
        /// 
        /// </summary>
        PageNumber,
        /// <summary>
        /// 
        /// </summary>
        ListItem,
        /// <summary>
        /// 
        /// </summary>
        Figure,
        /// <summary>
        /// 
        /// </summary>
        Table,
        /// <summary>
        /// 
        /// </summary>
        Form,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Footnote,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ElementTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ElementType value)
        {
            return value switch
            {
                ElementType.Header => "header",
                ElementType.Footer => "footer",
                ElementType.Title => "title",
                ElementType.SectionHeader => "section-header",
                ElementType.PageNumber => "page-number",
                ElementType.ListItem => "list-item",
                ElementType.Figure => "figure",
                ElementType.Table => "table",
                ElementType.Form => "form",
                ElementType.Text => "text",
                ElementType.Footnote => "footnote",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ElementType? ToEnum(string value)
        {
            return value switch
            {
                "header" => ElementType.Header,
                "footer" => ElementType.Footer,
                "title" => ElementType.Title,
                "section-header" => ElementType.SectionHeader,
                "page-number" => ElementType.PageNumber,
                "list-item" => ElementType.ListItem,
                "figure" => ElementType.Figure,
                "table" => ElementType.Table,
                "form" => ElementType.Form,
                "text" => ElementType.Text,
                "footnote" => ElementType.Footnote,
                _ => null,
            };
        }
    }
}