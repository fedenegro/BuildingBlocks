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

    /// <summary>A perimeter excluding other elements.</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.4.0 (Newtonsoft.Json v12.0.0.0)")]
    [UserElement]
	public partial class Exclusion : Element
    {
        [Newtonsoft.Json.JsonConstructor]
        public Exclusion(Polygon @perimeter, double @elevation, System.Guid @id, string @name)
            : base(id, name)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Exclusion>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @perimeter, @elevation, @id, @name});
            }
        
            this.Perimeter = @perimeter;
            this.Elevation = @elevation;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>The Exclusion perimeter.</summary>
        [Newtonsoft.Json.JsonProperty("Perimeter", Required = Newtonsoft.Json.Required.AllowNull)]
        public Polygon Perimeter { get; set; }
    
        /// <summary>The elevation in meters of the Exclusion.</summary>
        [Newtonsoft.Json.JsonProperty("Elevation", Required = Newtonsoft.Json.Required.Always)]
        public double Elevation { get; set; }
    
    
    }
}