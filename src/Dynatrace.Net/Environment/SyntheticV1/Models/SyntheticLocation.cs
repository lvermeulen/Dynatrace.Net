using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class SyntheticLocation
	{
		public string EntityId { get; set; }
		[JsonConverter(typeof(SyntheticLocationTypesConverter))]
		public SyntheticLocationTypes? Type { get; set; }
		public string Name { get; set; }
		public string CountryCode { get; set; }
		public string RegionCode { get; set; }
		public string City { get; set; }
		public decimal? Latitude { get; set; }
		public decimal? Longitude { get; set; }
		[JsonConverter(typeof(SyntheticLocationStatusTypesConverter))]
		public SyntheticLocationStatusTypes? Status { get; set; }
	}
}
