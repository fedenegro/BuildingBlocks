// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace StructureByEnvelope
{
    public class StructureByEnvelopeOutputs: ResultsBase
    {
		/// <summary>
		/// The maximum beam length.
		/// </summary>
		[JsonProperty("Maximum Beam Length")]
		public double MaximumBeamLength {get;}



        /// <summary>
        /// Construct a StructureByEnvelopeOutputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public StructureByEnvelopeOutputs() : base()
        {

        }


        /// <summary>
        /// Construct a StructureByEnvelopeOutputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public StructureByEnvelopeOutputs(double maximumBeamLength): base()
        {
			this.MaximumBeamLength = maximumBeamLength;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}