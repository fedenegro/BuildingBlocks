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

namespace LevelsByEnvelope
{
    public class LevelsByEnvelopeInputs: S3Args
    {
		/// <summary>
		/// Height of ground level.
		/// </summary>
		[JsonProperty("Ground Level Height")]
		public double GroundLevelHeight {get;}

		/// <summary>
		/// Standard height of repeated levels.
		/// </summary>
		[JsonProperty("Standard Level Height")]
		public double StandardLevelHeight {get;}

		/// <summary>
		/// Height of the top level.
		/// </summary>
		[JsonProperty("Penthouse Level Height")]
		public double PenthouseLevelHeight {get;}



        /// <summary>
        /// Construct a LevelsByEnvelopeInputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public LevelsByEnvelopeInputs() : base()
        {
			this.GroundLevelHeight = 20;
			this.StandardLevelHeight = 20;
			this.PenthouseLevelHeight = 20;

        }


        /// <summary>
        /// Construct a LevelsByEnvelopeInputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public LevelsByEnvelopeInputs(double groundLevelHeight, double standardLevelHeight, double penthouseLevelHeight, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey): base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
			this.GroundLevelHeight = groundLevelHeight;
			this.StandardLevelHeight = standardLevelHeight;
			this.PenthouseLevelHeight = penthouseLevelHeight;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}