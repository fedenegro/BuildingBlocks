// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

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

    /// <summary>A geometric polyline sketch.</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.21.0 (Newtonsoft.Json v12.0.0.0)")]
    
    [UserElement]
	public partial class Sketch : Element
    
    {
        [Newtonsoft.Json.JsonConstructor]
        public Sketch(Polyline @geometry, System.Guid @id, string @name)
            : base(id, name)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Sketch>();
            if(validator != null)
            {
                validator.PreConstruct(new object[]{ @geometry, @id, @name});
            }
        
            this.Geometry = @geometry;
        
            if(validator != null)
            {
                validator.PostConstruct(this);
            }
        }
    
        /// <summary>The Sketch Geometry.</summary>
        [Newtonsoft.Json.JsonProperty("Geometry", Required = Newtonsoft.Json.Required.AllowNull)]
        public Polyline Geometry { get; set; }
    
    
    }
}