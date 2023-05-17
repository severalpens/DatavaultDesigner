using DatavaultDesignerStar.Models.AdfConfig;
using DatavaultDesignerStar.Pages;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatavaultDesignerStar.Models.AdfConfig
{
    [Table("AdfConfigOriginals", Schema = "adfc")]
    public class AdfConfigOriginal
    {
        public int AdfConfigOriginalId { get; set; }
        public int? OldId { get; set; }
        public string? Source { get; set; }
        public string? Pattern { get; set; }
        public string? TableName { get; set; }
        public string? ParameterCode { get; set; }
        public string? ParameterValue { get; set; }

    }

    [Table("AdfConfigExtracts", Schema = "adfc")]
    public class AdfConfigExtract
    {
        public int AdfConfigExtractId { get; set; }
        public string ExtractSource { get; set; }
        public string? Source { get; set; }
        public string? Pattern { get; set; }
        public string? TableName { get; set; }
        public string? ParameterCode { get; set; }
        public string? ParameterValue { get; set; }
        public bool? IsValidJson { get; set; }

    }

    [Table("SchemaExtracts", Schema = "adfc")]
    public class SchemaExtract
    {
        public int SchemaExtractId { get; set; }
        public int? AdfConfigExtractId { get; set; }
        public int? ParentId { get; set; }
        public string? Name { get; set; }
        public string? Value { get; set; }
        public SchemaExtract? Parent { get; set; }
        public List<SchemaExtract>? Children { get; set; }

    }


    [Table("AdfConfigs", Schema = "adfc")]
    public class AdfConfig
    {
        public int AdfConfigId { get; set; }
        public int? LandingId { get; set; }
        public int? OldId { get; set; }
        public int? ParameterCodeId { get; set; }
        public string? Source { get; set; }
        public string? Pattern { get; set; }
        public string? TableName { get; set; }
    }



    [Table("ParameterCodes", Schema = "adfc")]
    public class ParameterCode
    {
        public int ParameterCodeId { get; set; }
        public string? Name { get; set; }

        public int? IsHubInfo { get; set; }

    }



    [Table("HubInfos", Schema = "adfc")]
    public class HubInfo
    {
        public int HubInfoId { get; set; }
        public int? AdfConfigId { get; set; }
        public string? Name { get; set; }
    }



    [Table("KeyMappings", Schema = "adfc")]
    public class KeyMapping
    {
        public int KeyMappingId { get; set; }
        public int? HubInfoId { get; set; }
        public string? Name { get; set; }
    }




    [Table("KeyMappingValues", Schema = "adfc")]
    public class KeyMappingValue
    {
        public int KeyMappingValueId { get; set; }
        public int? KeyMappingId { get; set; }
        public string? Value { get; set; }
    }




    [Table("HubInfoHubs", Schema = "adfc")]
    public class HubInfoHub
    {
        public int HubInfoHubId { get; set; }
        public int? HubInfoId { get; set; }
        public string? HubName { get; set; }
    }




    [Table("HubInfoHubKeys", Schema = "adfc")]
    public class HubInfoHubKey
    {
        public int HubInfoHubKeyId { get; set; }
        public int? HubInfoHubId { get; set; }
        public string? HubKeyName { get; set; }

    }

}

