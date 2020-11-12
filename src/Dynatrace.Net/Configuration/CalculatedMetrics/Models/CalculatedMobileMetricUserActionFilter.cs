using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.CalculatedMetrics.Models
{
	public class CalculatedMobileMetricUserActionFilter
	{
		public bool? HasReportedError { get; set; }
		public bool? HasHttpError { get; set; }
		public string UserActionName { get; set; }
		public string AppVersion { get; set; }
		public string Device { get; set; }
		public string Manufacturer { get; set; }
		[JsonConverter(typeof(ApdexTypesConverter))]
		public ApdexTypes? Apdex { get; set; }
		public string OsFamily { get; set; }
		public string OsVersion { get; set; }
		public string City { get; set; }
		public string Continent { get; set; }
		public string Country { get; set; }
		public string Region { get; set; }
		public int? ActionDurationFromMilliseconds { get; set; }
		public int? ActionDurationToMilliseconds { get; set; }
		public string Carrier { get; set; }
		[JsonConverter(typeof(ConnectionTypesConverter))]
		public ConnectionTypes? ConnectionType { get; set; }
		public string NetworkTechnology { get; set; }
		public string Isp { get; set; }
		[JsonConverter(typeof(OrientationTypesConverter))]
		public OrientationTypes? Orientation { get; set; }
		[JsonConverter(typeof(ResolutionTypesConverter))]
		public ResolutionTypes? Resolution { get; set; }
	}
}
