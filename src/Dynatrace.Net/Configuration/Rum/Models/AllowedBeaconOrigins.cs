using System.Collections.Generic;
using Dynatrace.Net.Common.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class AllowedBeaconOrigins
	{
		public ConfigurationMetadata Metadata { get; set; }
		[JsonProperty("allowedBeaconOrigins")]
		// ReSharper disable once InconsistentNaming
		public IEnumerable<BeaconDomainPattern> _AllowedBeaconOrigins { get; set; }
		public bool? RejectBeaconsWithoutOriginHeader { get; set; }
	}
}
