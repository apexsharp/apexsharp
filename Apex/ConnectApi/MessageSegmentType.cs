namespace Apex.ConnectApi
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    ///
    /// </summary>
    public enum MessageSegmentType
    {
        EntityLink,
        FieldChange,
        FieldChangeName,
        FieldChangeValue,
        Hashtag,
        InlineImage,
        Link,
        MarkupBegin,
        MarkupEnd,
        Mention,
        MoreChanges,
        ResourceLink,
        Text
    }
}
