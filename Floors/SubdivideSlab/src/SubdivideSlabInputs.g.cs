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

namespace SubdivideSlab
{
    public class SubdivideSlabInputs: S3Args
    {
		/// <summary>
		/// The max length of each subdivision.
		/// </summary>
		[JsonProperty("Length")]
		public double Length {get;}

		/// <summary>
		/// The max width of each subdivision.
		/// </summary>
		[JsonProperty("Width")]
		public double Width {get;}

		/// <summary>
		/// If true, splits will be inserted at the corners of voids.
		/// </summary>
		[JsonProperty("Subdivide at void corners")]
		public bool SubdivideAtVoidCorners {get;}

		/// <summary>
		/// If true, grid orientation will run parallel to the longest edge of the floor boundary.
		/// </summary>
		[JsonProperty("Align to longest edge")]
		public bool AlignToLongestEdge {get;}



        /// <summary>
        /// Construct a SubdivideSlabInputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public SubdivideSlabInputs() : base()
        {
			this.Length = 50;
			this.Width = 50;
			this.SubdivideAtVoidCorners = false;
			this.AlignToLongestEdge = false;

        }


        /// <summary>
        /// Construct a SubdivideSlabInputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public SubdivideSlabInputs(double length, double width, bool subdivideAtVoidCorners, bool alignToLongestEdge, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey): base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
			this.Length = length;
			this.Width = width;
			this.SubdivideAtVoidCorners = subdivideAtVoidCorners;
			this.AlignToLongestEdge = alignToLongestEdge;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}