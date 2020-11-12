using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Configuration.Services.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.CalculatedMetrics.Models
{
	public class DimensionDefinition
	{
		public string Name { get; set; }
		public string Dimension { get; set; }
		public IEnumerable<Placeholder> Placeholders { get; set; }
		public int? TopX { get; set; }
		[JsonConverter(typeof(DirectionsConverter))]
		public Directions? TopXDirection { get; set; }
		public string TopXAggregation { get; set; }
	}
}
