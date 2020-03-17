using System;
using System.Linq;
using System.Collections.Generic;
using Elements;
using Elements.Geometry;
using GeometryEx;

namespace CoreByEnvelope
{
      public static class CoreByEnvelope
    {
        /// <summary>
        /// The CoreByEnvelope function.
        /// </summary>
        /// <param name="model">The input model.</param>
        /// <param name="input">The arguments to the execution.</param>
        /// <returns>A CoreByEnvelopeOutputs instance containing computed results and the model with any new elements.</returns>
        public static CoreByEnvelopeOutputs Execute(Dictionary<string, Model> inputModels, 
                                                    CoreByEnvelopeInputs inputs)
        {
            var envelopes = new List<Envelope>();
            //Console.WriteLine(inputModels.Keys.First());
            inputModels.TryGetValue("Envelope", out var model);
            if (model == null || model.AllElementsOfType<Envelope>().Count() == 0)
            {
                throw new ArgumentException("No Envelope found.");
            }     
            envelopes.AddRange(model.AllElementsOfType<Envelope>());
            var coreDef = CoreMaker.MakeCore(inputs, envelopes);
            var extrude = new Elements.Geometry.Solids.Extrude(coreDef.perimeter, coreDef.height, Vector3.ZAxis, false);
            var shaft = new Elements.Geometry.Solids.Extrude(coreDef.perimeter, coreDef.height, Vector3.ZAxis, true);
            var corRep = new Representation(new List<Elements.Geometry.Solids.SolidOperation>() { extrude });
            var shfRep = new Representation(new List<Elements.Geometry.Solids.SolidOperation>() { shaft });
            var corMatl = new Material("serviceCore", Palette.Gray);
            var output = new CoreByEnvelopeOutputs(coreDef.length, coreDef.width, coreDef.rotation);
            envelopes.ForEach(e => output.model.AddElement(e));
            output.model.AddElement(new ServiceCore(coreDef.perimeter,
                                                    Vector3.ZAxis,
                                                    coreDef.elevation,
                                                    coreDef.height,
                                                    0.0,
                                                    null,
                                                    corMatl,
                                                    corRep,
                                                    false,
                                                    Guid.NewGuid(),
                                                    "Service Core"));
            output.model.AddElement(new Shaft(coreDef.perimeter,
                                              Vector3.ZAxis,
                                              coreDef.elevation,
                                              coreDef.height,
                                              coreDef.rotation,
                                              Math.Abs(coreDef.perimeter.Area()),
                                              Math.Abs(coreDef.perimeter.Area() * coreDef.height),
                                              null,
                                              corMatl,
                                              shfRep,
                                              false,
                                              Guid.NewGuid(),
                                              "Service Core Shaft"));
            return output;
        }
      }
}