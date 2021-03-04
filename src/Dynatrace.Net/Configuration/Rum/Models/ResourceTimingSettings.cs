using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class ResourceTimingSettings
	{
		public bool? W3CResourceTimings { get; set; }
		public bool? NonW3CResourceTimings { get; set; }
		public int? NonW3CResourceTimingsInstrumentationDelay { get; set; }
		[JsonConverter(typeof(ResourceTimingCaptureTypesConverter))]
		public ResourceTimingCaptureTypes? ResourceTimingCaptureType { get; set; }
		public int? ResourceTimingsDomainLimit { get; set; }
	}
}
