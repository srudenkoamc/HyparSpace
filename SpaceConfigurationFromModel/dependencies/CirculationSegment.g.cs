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

    /// <summary>Represents a section of a circulation network, such as a corridor.</summary>
    [JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v13.0.0.0)")]
    public partial class CirculationSegment : Floor
    {
        [JsonConstructor]
        public CirculationSegment(ThickenedPolyline @geometry, Profile @profile, double @thickness, System.Guid? @level, Transform @transform, Material @material, Representation @representation, bool @isElementDefinition, System.Guid @id, string @name)
            : base(profile, thickness, level, transform, material, representation, isElementDefinition, id, name)
        {
            this.Geometry = @geometry;
        }

        // Empty constructor
        public CirculationSegment()
            : base()
        {
        }

        /// <summary>The geometry of this circulation segment</summary>
        [JsonProperty("Geometry", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ThickenedPolyline Geometry { get; set; }


    }
}