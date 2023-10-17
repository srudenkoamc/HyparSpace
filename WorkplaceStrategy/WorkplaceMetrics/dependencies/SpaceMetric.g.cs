//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.21.0 (Newtonsoft.Json v13.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Spatial;
using Elements.Validators;
using Elements.Serialization.JSON;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements
{
    #pragma warning disable // Disable all warnings

    /// <summary>Attach these to spaces to include information useful for metrics and calculations</summary>
    [JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class SpaceMetric : Element
    {
        [JsonConstructor]
        public SpaceMetric(System.Guid? @space, double @seats, double @headcount, double @desks, double @collaborationSeats, System.Guid @id = default, string @name = null)
            : base(id, name)
        {
            this.Space = @space;
            this.Seats = @seats;
            this.Headcount = @headcount;
            this.Desks = @desks;
            this.CollaborationSeats = @collaborationSeats;
            }
        
        
        // Empty constructor
        public SpaceMetric()
            : base()
        {
        }
    
        /// <summary>The space we are attaching metrics to</summary>
        [JsonProperty("Space", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? Space { get; set; }
    
        /// <summary>Seat count for this space.</summary>
        [JsonProperty("Seats", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Seats { get; set; }
    
        /// <summary>Headcount for this space.</summary>
        [JsonProperty("Headcount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Headcount { get; set; }
    
        /// <summary>Desks for this space.</summary>
        [JsonProperty("Desks", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Desks { get; set; }
    
        /// <summary>Seats for collaboration in this space.</summary>
        [JsonProperty("Collaboration Seats", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double CollaborationSeats { get; set; }
    
    
    }
}