﻿namespace BExIS.Dim.Entities.Mapping
{

    //if you want to add keys here, please talk to david schöne
    // and then you will get a range of ids to set
    public enum Key
    {
        Author = 0, //also creator for Dublin Core
        Description = 1, // also for Dublin Core
        License = 2,
        ProjectTitle = 3,
        Title = 4,

        //Automatic System Keys starts at 100
        Id = 100,
        Version = 101,
        DateOfVersion = 102,
        MetadataCreationDate = 103,
        MetadataLastModfied = 104,
        DataCreationDate = 105,
        DataLastModified = 106, // also for Dubline Core date 

        //Additional Dublin Core nodes starts at 200
        Subject = 200,
        Publisher = 201,
        Contributor = 202,
        Type = 203, //Examples:Type = "image", Type = "sound", Type = "text"
        Format = 204, //e.g. Format="image/gif"
        Identifier = 205, //Open Identifier
        Source = 206,
        Language = 207,
        Relation = 208,
        Coverage = 209,
        Rights = 210
    }

    public enum LinkElementComplexity
    {
        None,
        Simple,
        Complex
    }

    public enum LinkElementType
    {
        MetadataStructure = 0,
        XSD = 1,
        System = 2,
        SimpleMetadataAttribute = 3,
        ComplexMetadataAttribute = 4,
        MetadataAttributeUsage = 5,
        MetadataNestedAttributeUsage = 6,
        MetadataPackage = 7,
        MetadataPackageUsage = 8,
        PartyType = 9,
        PartyCustomType = 10,
        Key = 11,
        Role = 12,
        PartyRelationshipType = 13
    }



    public class LinkElementMetadataStructure : LinkElement { }
    public class LinkElementXsd : LinkElement { }
    public class LinkElementSystem : LinkElement { }
    public class LinkElementSimpleMetadataAttribute : LinkElement { }
    public class LinkElementComplexMetadatAttribute : LinkElement { }
    public class LinkElementMetadatAttributeUsage : LinkElement { }
    public class LinkElementMetadataNestedAttributeUsage : LinkElement { }
    public class LinkElementMetadataPackage : LinkElement { }
    public class LinkElementMetadataPackageUsage : LinkElement { }
    public class LinkElementPartyType : LinkElement { }
    public class LinkElementParty : LinkElement { }
    public class LinkElementKey : LinkElement { }
    public class LinkElementRole : LinkElement { }



}
