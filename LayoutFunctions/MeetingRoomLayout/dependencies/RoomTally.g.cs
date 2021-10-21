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

    /// <summary>Table of present seats by room type</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class RoomTally : Element
    {
        [Newtonsoft.Json.JsonConstructor]
        public RoomTally(string @roomType, int @seatsCount, System.Guid @id = default, string @name = null)
            : base(id, name)
        {
            this.RoomType = @roomType;
            this.SeatsCount = @seatsCount;
            }
        
        // Empty constructor
        public RoomTally()
            : base()
        {
        }
    
        [Newtonsoft.Json.JsonProperty("Room type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RoomType { get; set; }
    
        [Newtonsoft.Json.JsonProperty("SeatsCount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int SeatsCount { get; set; }
    
    
    }
}