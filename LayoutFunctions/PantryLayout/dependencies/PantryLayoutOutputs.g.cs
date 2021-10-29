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

namespace PantryLayout
{
    public class PantryLayoutOutputs: ResultsBase
    {
		/// <summary>
		/// Total count of seats
		/// </summary>
		[JsonProperty("Total cafe chairs count")]
		public double TotalCafeChairsCount {get; set;}



        /// <summary>
        /// Construct a PantryLayoutOutputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public PantryLayoutOutputs() : base()
        {

        }


        /// <summary>
        /// Construct a PantryLayoutOutputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public PantryLayoutOutputs(double totalCafeChairsCount): base()
        {
			this.TotalCafeChairsCount = totalCafeChairsCount;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}