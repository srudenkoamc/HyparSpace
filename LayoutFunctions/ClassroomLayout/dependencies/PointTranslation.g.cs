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

    /// <summary>Location of a point relative to an original location, for use with overrides.</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class PointTranslation : GeometricElement
    {
        [Newtonsoft.Json.JsonConstructor]
        public PointTranslation(Vector3 @location, Vector3 @originalLocation, Transform @transform = null, Material @material = null, Representation @representation = null, bool @isElementDefinition = false, System.Guid @id = default, string @name = null)
            : base(transform, material, representation, isElementDefinition, id, name)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<PointTranslation>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @location, @originalLocation, @transform, @material, @representation, @isElementDefinition, @id, @name});
            }
        
            this.Location = @location;
            this.OriginalLocation = @originalLocation;
            
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>The new location</summary>
        [Newtonsoft.Json.JsonProperty("Location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Vector3 Location { get; set; }
    
        /// <summary>The original location</summary>
        [Newtonsoft.Json.JsonProperty("OriginalLocation", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Vector3 OriginalLocation { get; set; }
    
    
    }
}