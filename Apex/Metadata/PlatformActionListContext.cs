namespace Apex.Metadata
{
    using ApexSharp;
    using ApexSharp.ApexAttributes;
    using ApexSharp.Implementation;
    using global::Apex.System;

    /// <summary>
    /// https://developer.salesforce.com/docs/atlas.en-us.apexcode.meta/apexcode/apex_enum_Metadata_PlatformActionListContextEnum.htm
    /// </summary>
    public enum PlatformActionListContext
    {
        Assistant,
        BannerPhoto,
        Chatter,
        Dockable,
        FeedElement,
        Flexipage,
        Global_x,
        ListView,
        ListViewDefinition,
        ListViewRecord,
        Lookup,
        MruList,
        MruRow,
        ObjectHomeChart,
        Photo,
        Record,
        RecordEdit,
        RelatedList,
        RelatedListRecord
    }
}
