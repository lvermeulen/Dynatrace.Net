using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.SyntheticV1.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.SyntheticV2.Models
{
	public class LocationCollectionElement
	{
		public string Name { get; set; }
		public string EntityId { get; set; }
		[JsonConverter(typeof(SyntheticLocationTypesConverter))]
		public SyntheticLocationTypes? Type { get; set; }
		[JsonConverter(typeof(SyntheticLocationV2CloudPlatformsConverter))]
		public SyntheticLocationV2CloudPlatforms? CloudPlatform { get; set; }
		public IEnumerable<string> Ips { get; set; }
		[JsonConverter(typeof(ReleaseStagesConverter))]
		public ReleaseStages? Stage { get; set; }
		[JsonConverter(typeof(SyntheticLocationStatusTypesConverter))]
		public SyntheticLocationStatusTypes? Status { get; set; }
		public string GeoLocationId { get; set; }
	}
}
