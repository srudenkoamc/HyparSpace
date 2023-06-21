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

namespace PlantEntourage
{
    #pragma warning disable // Disable all warnings

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public  class PlantEntourageInputs : S3Args
    
    {
        [Newtonsoft.Json.JsonConstructor]
        
        public PlantEntourageInputs(double @plantDensity, IList<string> @programTypes, Overrides @overrides, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey):
        base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<PlantEntourageInputs>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @plantDensity, @programTypes, @overrides});
            }
        
            this.PlantDensity = @plantDensity;
            this.ProgramTypes = @programTypes;
            this.Overrides = @overrides ?? this.Overrides;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>Area per plant.</summary>
        [Newtonsoft.Json.JsonProperty("Plant Density", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(15D, 30D)]
        public double PlantDensity { get; set; } = 20D;
    
        /// <summary>Plants will be added to Space Boundaries with these Program Types only.</summary>
        [Newtonsoft.Json.JsonProperty("Program Types", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<string> ProgramTypes { get; set; } = new List<string>();
    
        [Newtonsoft.Json.JsonProperty("overrides", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Overrides Overrides { get; set; } = new Overrides();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class Overrides 
    
    {
        public Overrides() { }
        
        [Newtonsoft.Json.JsonConstructor]
        public Overrides(OverrideAdditions @additions, OverrideRemovals @removals, IList<PlantsOverride> @plants)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Overrides>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @additions, @removals, @plants});
            }
        
            this.Additions = @additions ?? this.Additions;
            this.Removals = @removals ?? this.Removals;
            this.Plants = @plants ?? this.Plants;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Additions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OverrideAdditions Additions { get; set; } = new OverrideAdditions();
    
        [Newtonsoft.Json.JsonProperty("Removals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OverrideRemovals Removals { get; set; } = new OverrideRemovals();
    
        [Newtonsoft.Json.JsonProperty("Plants", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<PlantsOverride> Plants { get; set; } = new List<PlantsOverride>();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class OverrideAdditions 
    
    {
        public OverrideAdditions() { }
        
        [Newtonsoft.Json.JsonConstructor]
        public OverrideAdditions(IList<PlantsOverrideAddition> @plants)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<OverrideAdditions>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @plants});
            }
        
            this.Plants = @plants ?? this.Plants;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Plants", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<PlantsOverrideAddition> Plants { get; set; } = new List<PlantsOverrideAddition>();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class OverrideRemovals 
    
    {
        public OverrideRemovals() { }
        
        [Newtonsoft.Json.JsonConstructor]
        public OverrideRemovals(IList<PlantsOverrideRemoval> @plants)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<OverrideRemovals>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @plants});
            }
        
            this.Plants = @plants ?? this.Plants;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Plants", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<PlantsOverrideRemoval> Plants { get; set; } = new List<PlantsOverrideRemoval>();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class PlantsOverride 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public PlantsOverride(string @id, PlantsIdentity @identity, PlantsValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<PlantsOverride>();
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
        public PlantsIdentity Identity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PlantsValue Value { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class PlantsOverrideAddition 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public PlantsOverrideAddition(string @id, PlantsIdentity @identity, PlantsOverrideAdditionValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<PlantsOverrideAddition>();
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
    
        [Newtonsoft.Json.JsonProperty("Identity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PlantsIdentity Identity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PlantsOverrideAdditionValue Value { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class PlantsOverrideRemoval 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public PlantsOverrideRemoval(string @id, PlantsIdentity @identity)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<PlantsOverrideRemoval>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @id, @identity});
            }
        
            this.Id = @id;
            this.Identity = @identity;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Identity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PlantsIdentity Identity { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class PlantsIdentity 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public PlantsIdentity(Vector3 @originalPosition)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<PlantsIdentity>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @originalPosition});
            }
        
            this.OriginalPosition = @originalPosition;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("OriginalPosition", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Vector3 OriginalPosition { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class PlantsValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public PlantsValue(Transform @transform)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<PlantsValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @transform});
            }
        
            this.Transform = @transform;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Transform", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Transform Transform { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class PlantsOverrideAdditionValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public PlantsOverrideAdditionValue(Transform @transform)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<PlantsOverrideAdditionValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @transform});
            }
        
            this.Transform = @transform;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Transform", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Transform Transform { get; set; }
    
    }
}