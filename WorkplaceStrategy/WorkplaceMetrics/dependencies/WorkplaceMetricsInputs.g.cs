// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Validators;
using Elements.Serialization.JSON;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Hypar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace WorkplaceMetrics
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public  class WorkplaceMetricsInputs : S3Args
    
    {
        [Newtonsoft.Json.JsonConstructor]
        
        public WorkplaceMetricsInputs(WorkplaceMetricsInputsCalculationMode @calculationMode, int @totalHeadcount, double @deskSharingRatio, IList<Polygon> @uSFExclusions, Overrides @overrides, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey):
        base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<WorkplaceMetricsInputs>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @calculationMode, @totalHeadcount, @deskSharingRatio, @uSFExclusions, @overrides});
            }
        
            this.CalculationMode = @calculationMode;
            this.TotalHeadcount = @totalHeadcount;
            this.DeskSharingRatio = @deskSharingRatio;
            this.USFExclusions = @uSFExclusions;
            this.Overrides = @overrides ?? this.Overrides;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Calculation Mode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WorkplaceMetricsInputsCalculationMode CalculationMode { get; set; } = WorkplaceMetricsInputsCalculationMode.Fixed_Headcount;
    
        /// <summary>How many people will occupy this workspace?</summary>
        [Newtonsoft.Json.JsonProperty("Total Headcount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int TotalHeadcount { get; set; }
    
        /// <summary>What is the assumed sharing ratio: How many people for every desk? A value of 1 means one desk for every person; A value of 2 means there's only one desk for every two people.</summary>
        [Newtonsoft.Json.JsonProperty("Desk Sharing Ratio", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(1D, double.MaxValue)]
        public double DeskSharingRatio { get; set; } = 1D;
    
        /// <summary>Draw regions around areas intended to be excluded from USF calculation. This typically includes elevator shafts and stairwells for a full floor lease.</summary>
        [Newtonsoft.Json.JsonProperty("USF Exclusions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<Polygon> USFExclusions { get; set; } = new List<Polygon>();
    
        [Newtonsoft.Json.JsonProperty("overrides", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Overrides Overrides { get; set; } = new Overrides();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum WorkplaceMetricsInputsCalculationMode
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Fixed Headcount")]
        Fixed_Headcount = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Fixed Sharing Ratio")]
        Fixed_Sharing_Ratio = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class Overrides 
    
    {
        public Overrides() { }
        
        [Newtonsoft.Json.JsonConstructor]
        public Overrides(IList<SettingsOverride> @settings)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Overrides>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @settings});
            }
        
            this.Settings = @settings ?? this.Settings;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Settings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<SettingsOverride> Settings { get; set; } = new List<SettingsOverride>();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class SettingsOverride 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public SettingsOverride(string @id, SettingsIdentity @identity, SettingsValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<SettingsOverride>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @identity, @value});
            }
        
            this.Id = @id;
            this.Identity = @identity;
            this.Value = @value;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Identity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SettingsIdentity Identity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SettingsValue Value { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class SettingsIdentity 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public SettingsIdentity(string @name)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<SettingsIdentity>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @name});
            }
        
            this.Name = @name;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class SettingsValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public SettingsValue(double @rentableArea, double @usableArea)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<SettingsValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @rentableArea, @usableArea});
            }
        
            this.RentableArea = @rentableArea;
            this.UsableArea = @usableArea;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>Adjust the Rentable Area for calculations + display.  Note: unless you update this manually, it is computed using a fixed ratio of 1.2 * Usable Area.</summary>
        [Newtonsoft.Json.JsonProperty("Rentable Area", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double RentableArea { get; set; }
    
        /// <summary>Adjust the Usable Area for calculations + display.</summary>
        [Newtonsoft.Json.JsonProperty("Usable Area", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double UsableArea { get; set; }
    
    }
}