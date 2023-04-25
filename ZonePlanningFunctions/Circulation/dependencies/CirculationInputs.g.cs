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

namespace Circulation
{
    #pragma warning disable // Disable all warnings

    /// <summary>A polyline that has been thickened into a polygon.</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class ThickenedPolyline 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public ThickenedPolyline(Polyline @polyline, double? @width, bool? @flip, double @leftWidth, double @rightWidth)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<ThickenedPolyline>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @polyline, @width, @flip, @leftWidth, @rightWidth});
            }
        
            this.Polyline = @polyline;
            this.Width = @width;
            this.Flip = @flip;
            this.LeftWidth = @leftWidth;
            this.RightWidth = @rightWidth;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("polyline", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Polyline Polyline { get; set; }
    
        [Newtonsoft.Json.JsonProperty("width", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Width { get; set; }
    
        [Newtonsoft.Json.JsonProperty("flip", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Flip { get; set; }
    
        /// <summary>The amount to thicken the polyline on its "left" side, imagining that the polyline is extending away from you. That is, if the polyline starts at (0,0,0) and follows the +Z axis, the left side extends into the -X quadrant.</summary>
        [Newtonsoft.Json.JsonProperty("leftWidth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double LeftWidth { get; set; }
    
        /// <summary>The amount to thicken the polyline on its "right" side, imagining that the polyline is extending away from you. That is, if the polyline starts at (0,0,0) and follows the +Z axis, the right side extends into the +X quadrant.</summary>
        [Newtonsoft.Json.JsonProperty("rightWidth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double RightWidth { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public  class CirculationInputs : S3Args
    
    {
        [Newtonsoft.Json.JsonConstructor]
        
        public CirculationInputs(CirculationInputsCirculationMode @circulationMode, double @corridorWidth, double @outerBandDepth, double @depthAtEnds, IList<ThickenedPolyline> @addCorridors, Overrides @overrides, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey):
        base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<CirculationInputs>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @circulationMode, @corridorWidth, @outerBandDepth, @depthAtEnds, @addCorridors, @overrides});
            }
        
            this.CirculationMode = @circulationMode;
            this.CorridorWidth = @corridorWidth;
            this.OuterBandDepth = @outerBandDepth;
            this.DepthAtEnds = @depthAtEnds;
            this.AddCorridors = @addCorridors;
            this.Overrides = @overrides ?? this.Overrides;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>How should circulation be calculated? 
        /// Automatic: a typical circulation network will be generated for you. 
        /// Manual: you draw the circulation paths yourself.</summary>
        [Newtonsoft.Json.JsonProperty("Circulation Mode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CirculationInputsCirculationMode CirculationMode { get; set; } = CirculationInputsCirculationMode.Automatic;
    
        /// <summary>How wide should circulation paths be?</summary>
        [Newtonsoft.Json.JsonProperty("Corridor Width", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0.3D, double.MaxValue)]
        public double CorridorWidth { get; set; } = 1.5D;
    
        /// <summary>For the "outer band" of program running along the floor perimeter, how deep should the spaces be?</summary>
        [Newtonsoft.Json.JsonProperty("Outer Band Depth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(1.0D, 20.0D)]
        public double OuterBandDepth { get; set; } = 6D;
    
        /// <summary>If your floorplate is rectangular, or has roughly rectangular ends, how deep should the spaces be at these ends?</summary>
        [Newtonsoft.Json.JsonProperty("Depth at Ends", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(1.0D, 20.0D)]
        public double DepthAtEnds { get; set; } = 8D;
    
        /// <summary>Insert additional corridors, to further subdivide the space.</summary>
        [Newtonsoft.Json.JsonProperty("Add Corridors", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<ThickenedPolyline> AddCorridors { get; set; }
    
        [Newtonsoft.Json.JsonProperty("overrides", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Overrides Overrides { get; set; } = new Overrides();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    public enum CirculationInputsCirculationMode
    {
        [System.Runtime.Serialization.EnumMember(Value = @"Automatic")]
        Automatic = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"Manual")]
        Manual = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class Overrides 
    
    {
        public Overrides() { }
        
        [Newtonsoft.Json.JsonConstructor]
        public Overrides(OverrideAdditions @additions, OverrideRemovals @removals, IList<CorridorsOverride> @corridors)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Overrides>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @additions, @removals, @corridors});
            }
        
            this.Additions = @additions ?? this.Additions;
            this.Removals = @removals ?? this.Removals;
            this.Corridors = @corridors ?? this.Corridors;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Additions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OverrideAdditions Additions { get; set; } = new OverrideAdditions();
    
        [Newtonsoft.Json.JsonProperty("Removals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public OverrideRemovals Removals { get; set; } = new OverrideRemovals();
    
        [Newtonsoft.Json.JsonProperty("Corridors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<CorridorsOverride> Corridors { get; set; } = new List<CorridorsOverride>();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class OverrideAdditions 
    
    {
        public OverrideAdditions() { }
        
        [Newtonsoft.Json.JsonConstructor]
        public OverrideAdditions(IList<CorridorsOverrideAddition> @corridors)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<OverrideAdditions>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @corridors});
            }
        
            this.Corridors = @corridors ?? this.Corridors;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Corridors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<CorridorsOverrideAddition> Corridors { get; set; } = new List<CorridorsOverrideAddition>();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class OverrideRemovals 
    
    {
        public OverrideRemovals() { }
        
        [Newtonsoft.Json.JsonConstructor]
        public OverrideRemovals(IList<CorridorsOverrideRemoval> @corridors)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<OverrideRemovals>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @corridors});
            }
        
            this.Corridors = @corridors ?? this.Corridors;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Corridors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IList<CorridorsOverrideRemoval> Corridors { get; set; } = new List<CorridorsOverrideRemoval>();
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class CorridorsOverride 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public CorridorsOverride(string @id, CorridorsIdentity @identity, CorridorsValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<CorridorsOverride>();
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
        public CorridorsIdentity Identity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CorridorsValue Value { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class CorridorsOverrideAddition 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public CorridorsOverrideAddition(string @id, CorridorsIdentity @identity, CorridorsOverrideAdditionValue @value)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<CorridorsOverrideAddition>();
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
        public CorridorsIdentity Identity { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Value", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CorridorsOverrideAdditionValue Value { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class CorridorsOverrideRemoval 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public CorridorsOverrideRemoval(string @id, CorridorsIdentity @identity)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<CorridorsOverrideRemoval>();
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
        public CorridorsIdentity Identity { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class CorridorsIdentity 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public CorridorsIdentity(Polyline @originalGeometry)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<CorridorsIdentity>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @originalGeometry});
            }
        
            this.OriginalGeometry = @originalGeometry;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Original Geometry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Polyline OriginalGeometry { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class CorridorsValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public CorridorsValue(ThickenedPolyline @geometry)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<CorridorsValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @geometry});
            }
        
            this.Geometry = @geometry;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Geometry", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ThickenedPolyline Geometry { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class CorridorsOverrideAdditionValue 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public CorridorsOverrideAdditionValue(ThickenedPolyline @geometry, CorridorsOverrideAdditionValueLevel @level)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<CorridorsOverrideAdditionValue>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @geometry, @level});
            }
        
            this.Geometry = @geometry;
            this.Level = @level;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Geometry", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ThickenedPolyline Geometry { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Level", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CorridorsOverrideAdditionValueLevel Level { get; set; }
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    
    public partial class CorridorsOverrideAdditionValueLevel 
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public CorridorsOverrideAdditionValueLevel(Transform @transform, string @name, string @buildingName)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<CorridorsOverrideAdditionValueLevel>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @transform, @name, @buildingName});
            }
        
            this.Transform = @transform;
            this.Name = @name;
            this.BuildingName = @buildingName;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        [Newtonsoft.Json.JsonProperty("Transform", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Transform Transform { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Building Name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BuildingName { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
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