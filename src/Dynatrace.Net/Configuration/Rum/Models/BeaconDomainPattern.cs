using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class BeaconDomainPattern
	{
		[JsonConverter(typeof(DomainNameMatchersConverter))]
		public DomainNameMatchers? DomainNameMatcher { get; set; }
		public string DomainNamePattern { get; set; }
	}
}
