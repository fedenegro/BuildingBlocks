//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.4.0 (Newtonsoft.Json v12.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Properties;
using Elements.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements
{
    #pragma warning disable // Disable all warnings

    /// <summary>Represents a vertical shaft.</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.4.0 (Newtonsoft.Json v12.0.0.0)")]
    [UserElement]
	public partial class Shaft : GeometricElement
    {
        [Newtonsoft.Json.JsonConstructor]
        public Shaft(Polygon @perimeter, Vector3 @direction, double @elevation, double @height, double @rotation, double @area, double @volume, Transform @transform, Material @material, Representation @representation, bool @isElementDefinition, System.Guid @id, string @name)
            : base(transform, material, representation, isElementDefinition, id, name)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Shaft>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @perimeter, @direction, @elevation, @height, @rotation, @area, @volume, @transform, @material, @representation, @isElementDefinition, @id, @name});
            }
        
            this.Perimeter = @perimeter;
            this.Direction = @direction;
            this.Elevation = @elevation;
            this.Height = @height;
            this.Rotation = @rotation;
            this.Area = @area;
            this.Volume = @volume;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>The id of the polygon to extrude.</summary>
        [Newtonsoft.Json.JsonProperty("Perimeter", Required = Newtonsoft.Json.Required.AllowNull)]
        public Polygon Perimeter { get; set; }
    
        /// <summary>The direction in which to extrude.</summary>
        [Newtonsoft.Json.JsonProperty("Direction", Required = Newtonsoft.Json.Required.AllowNull)]
        public Vector3 Direction { get; set; }
    
        /// <summary>The elevation of the shaft</summary>
        [Newtonsoft.Json.JsonProperty("Elevation", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double Elevation { get; set; }
    
        /// <summary>The height of the shaft.</summary>
        [Newtonsoft.Json.JsonProperty("Height", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0D, double.MaxValue)]
        public double Height { get; set; }
    
        /// <summary>The rotation in degrees of the shaft.</summary>
        [Newtonsoft.Json.JsonProperty("Rotation", Required = Newtonsoft.Json.Required.Always)]
        public double Rotation { get; set; }
    
        /// <summary>The area of the shaft footprint.</summary>
        [Newtonsoft.Json.JsonProperty("Area", Required = Newtonsoft.Json.Required.Always)]
        public double Area { get; set; }
    
        /// <summary>The volume of the shaft.</summary>
        [Newtonsoft.Json.JsonProperty("Volume", Required = Newtonsoft.Json.Required.Always)]
        public double Volume { get; set; }
    
    
    }
}