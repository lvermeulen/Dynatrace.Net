using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Environment.UserSessions.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class MobileCustomAppConfig
	{
		public string Identifier { get; set; }
		public string Name { get; set; }
		[JsonConverter(typeof(ApplicationTypesConverter))]
		public ApplicationTypes? ApplicationType { get; set; }
		public string ApplicationId { get; set; }
		[JsonConverter(typeof(IconTypesConverter))]
		public IconTypes? IconType { get; set; }
		public int? CostControlUserSessionPercentage { get; set; }
		public MobileCustomApdex ApdexSettings { get; set; }
		public bool? OptInModeEnabled { get; set; }
		public bool? SessionReplayOnCrashEnabled { get; set; }
		[JsonConverter(typeof(BeaconEndpointTypesConverter))]
		public BeaconEndpointTypes? BeaconEndpointType { get; set; }
		public string BeaconEndpointUrl { get; set; }
	}
}
