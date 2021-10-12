//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.21.0 (Newtonsoft.Json v12.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Spatial;
using Elements.Validators;
using Elements.Serialization.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements
{
    #pragma warning disable // Disable all warnings

    /// <summary>A tally of the area deltas between targets + results</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class AreaTally : Element
    {
        [Newtonsoft.Json.JsonConstructor]
        public AreaTally(string @programType, Color @programColor, double @areaTarget, double @achievedArea, double @distinctAreaCount, double? @targetCount, double? @achievedCount, string @cost, System.Guid @id = default, string @name = null)
            : base(id, name)
        {
            this.ProgramType = @programType;
            this.ProgramColor = @programColor;
            this.AreaTarget = @areaTarget;
            this.AchievedArea = @achievedArea;
            this.DistinctAreaCount = @distinctAreaCount;
            this.TargetCount = @targetCount;
            this.AchievedCount = @achievedCount;
            this.Cost = @cost;
            }
    
        [Newtonsoft.Json.JsonProperty("Program Type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProgramType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Program Color", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Color ProgramColor { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Area Target", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double AreaTarget { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Achieved Area", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double AchievedArea { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Distinct Area Count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double DistinctAreaCount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Target Count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TargetCount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Achieved Count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AchievedCount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("Cost", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Cost { get; set; }
    
    
    }
}