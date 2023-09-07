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

namespace DefineProgramRequirements
{
    #pragma warning disable // Disable all warnings

    /// <summary>A hosted file reference from InputData</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class InputFileRef : InputData
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public InputFileRef(string @fileRefId, string @fileName, string @folderId, string @key, string @localFilePath)
            : base(key, localFilePath)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<InputFileRef>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @fileRefId, @fileName, @folderId, @key, @localFilePath});
            }
        
            this.FileRefId = @fileRefId;
            this.FileName = @fileName;
            this.FolderId = @folderId;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("FileRefId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FileRefId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("FileName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FileName { get; set; }
    
        [Newtonsoft.Json.JsonProperty("FolderId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FolderId { get; set; }
    
    }
    
    /// <summary>A folder of content sent to a function during execution</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class InputFolder 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public InputFolder(string @id, IList<InputFileRef> @files, string @name)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<InputFolder>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @files, @name});
            }
        
            this.Id = @id;
            this.Files = @files;
            this.Name = @name;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Files", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<InputFileRef> Files { get; set; }
    
        /// <summary>The name of the folder</summary>
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public  class DefineProgramRequirementsInputs : S3Args
    
    {
        [Newtonsoft.Json.JsonConstructor]
        
        public DefineProgramRequirementsInputs(bool @showAdvancedOptions, IList<ProgramRequirements> @programRequirements, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey):
        base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<DefineProgramRequirementsInputs>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @showAdvancedOptions, @programRequirements});
            }
        
            this.ShowAdvancedOptions = @showAdvancedOptions;
            this.ProgramRequirements = @programRequirements;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Show Advanced Options", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool ShowAdvancedOptions { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("Program Requirements", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<ProgramRequirements> ProgramRequirements { get; set; }
    
    }
    
    /// <summary>Fill out your program requirements. Use "Layout Type" to dictate which function should be used to lay out your space.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class ProgramRequirements 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public ProgramRequirements(string @programGroup, string @programName, Color? @color, double @areaPerSpace, int @spaceCount, double? @width, double? @depth, string @hyparSpaceType, ProgramRequirementsCountType @countType, InputFolder @layoutType, bool? @enclosed)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<ProgramRequirements>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @programGroup, @programName, @color, @areaPerSpace, @spaceCount, @width, @depth, @hyparSpaceType, @countType, @layoutType, @enclosed});
            }
        
            this.ProgramGroup = @programGroup;
            this.ProgramName = @programName;
            this.Color = @color;
            this.AreaPerSpace = @areaPerSpace;
            this.SpaceCount = @spaceCount;
            this.Width = @width;
            this.Depth = @depth;
            this.HyparSpaceType = @hyparSpaceType;
            this.CountType = @countType;
            this.LayoutType = @layoutType;
            this.Enclosed = @enclosed;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>What group does this program belong to?</summary>
        [Newtonsoft.Json.JsonProperty("Program Group", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProgramGroup { get; set; }
    
        /// <summary>What display name should be used for this program type?</summary>
        [Newtonsoft.Json.JsonProperty("Program Name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ProgramName { get; set; }
    
        /// <summary>What color should be used to display this space type?</summary>
        [Newtonsoft.Json.JsonProperty("Color", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Color? Color { get; set; }
    
        /// <summary>How much area should be allocated for this space?</summary>
        [Newtonsoft.Json.JsonProperty("Area per Space", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double AreaPerSpace { get; set; }
    
        /// <summary>How many of this space type are required? Leave at 1 for spaces measured in aggregate, like circulation.</summary>
        [Newtonsoft.Json.JsonProperty("Space Count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int SpaceCount { get; set; } = 1;
    
        /// <summary>Optional. (Typically the longer dimension — along the side from which the space is accessed, like a corridor.)</summary>
        [Newtonsoft.Json.JsonProperty("Width", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Width { get; set; }
    
        /// <summary>Optional. (Typically the shorter dimension — perpendicular to the side from which the space is accessed, like a corridor.)</summary>
        [Newtonsoft.Json.JsonProperty("Depth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Depth { get; set; }
    
        /// <summary>Which furniture layout function should be used to lay out this space?</summary>
        [Newtonsoft.Json.JsonProperty("Hypar Space Type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HyparSpaceType { get; set; } = "unspecified";
    
        /// <summary>How should this requirement be counted? 
        /// 
        /// Use "Item" for individual spaces (e.g. 3 conference rooms),
        /// "Area Total" for spaces where you only care about the total (e.g. 1000 SF of circulation), and 
        /// "Unit" where you want total area divided by a "unit" size (e.g. this space supports 400 people at 120 SF / person)</summary>
        [Newtonsoft.Json.JsonProperty("Count Type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ProgramRequirementsCountType CountType { get; set; } = ProgramRequirementsCountType.Item;
    
        /// <summary>What sort of room type should be used to lay out furniture and equipment in this space?</summary>
        [Newtonsoft.Json.JsonProperty("Layout Type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public InputFolder LayoutType { get; set; }
    
        /// <summary>Should this space be enclosed by walls?</summary>
        [Newtonsoft.Json.JsonProperty("Enclosed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Enclosed { get; set; } = true;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum ProgramRequirementsCountType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Item")]
        Item = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Area Total")]
        Area_Total = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
    internal class JsonInheritanceAttribute : System.Attribute
    {
        public JsonInheritanceAttribute(string key, System.Type type)
        {
            Key = key;
            Type = type;
        }
    
        public string Key { get; }
    
        public System.Type Type { get; }
    }
}