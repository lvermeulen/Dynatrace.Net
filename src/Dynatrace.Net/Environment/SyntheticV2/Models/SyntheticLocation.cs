using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Environment.SyntheticV1.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.SyntheticV2.Models
{
	public class SyntheticLocation
	{
		public string EntityId { get; set; }
		public string Type { get; set; }
		public string Name { get; set; }
		public string City { get; set; }
		public decimal? Latitude { get; set; }
		public decimal? Longitude { get; set; }
		[JsonConverter(typeof(SyntheticLocationStatusTypesConverter))]
		public SyntheticLocationStatusTypes? Status { get; set; }
	}
}
