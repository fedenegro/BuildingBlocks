﻿using Xunit;
using System.Linq;
using Newtonsoft.Json;
using Elements;
using Hypar.Functions.Execution.Local;
using Elements.Serialization.glTF;
using Elements.Serialization.JSON;
using System.Collections.Generic;
using Elements.Geometry;


namespace RoofBySketch.Tests
{
    /// <summary>
    /// Writes all new Elements to JSON output.
    /// Writes all new Elements and any incoming contextual Elements to GLB output.
    /// </summary>
    public class RoofBySketchTests
    {
        private const string OUTPUT = "../../../_output/";

        [Fact]
        public void RoofBySketchTest()
        {
            var polygon =
                new Polygon(
                    new[]
                    {
                        new Vector3(20.0, 20.0),
                        new Vector3(40.0, 20.0),
                        new Vector3(40.0, 40.0),
                        new Vector3(20.0, 40.0)
                    });
            var inputs = 
                new RoofBySketchInputs(
                    perimeter: polygon,
                    roofElevation: 55.0,
                    roofThickness: 0.25,
                    "", "", new Dictionary<string, string>(), "", "", "");
            var outputs = RoofBySketch.Execute(new Dictionary<string, Model> { { "Test", new Model() } }, inputs);
            System.IO.File.WriteAllText(OUTPUT + "RoofBySketch.json", outputs.Model.ToJson());
            outputs.Model.ToGlTF(OUTPUT + "RoofBySketch.glb");
        }
    }
}
