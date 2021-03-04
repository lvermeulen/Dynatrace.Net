using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class WebApplicationConfig
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Identifier { get; set; }
		public string Name { get; set; }
		[JsonConverter(typeof(WebApplicationTypesConverter))]
		public WebApplicationTypes? Type { get; set; }
		public bool? RealUserMonitoringEnabled { get; set; }
		public decimal? CostControlUserSessionPercentage { get; set; }
		[JsonConverter(typeof(LoadActionKeyPerformanceMetricsConverter))]
		public LoadActionKeyPerformanceMetrics? LoadActionKeyPerformanceMetric { get; set; }
		public SessionReplaySetting SessionReplayConfig { get; set; }
		[JsonConverter(typeof(XhrActionKeyPerformanceMetricsConverter))]
		public XhrActionKeyPerformanceMetrics? XhrActionKeyPerformanceMetric { get; set; }
		public Apdex LoadActionApdexSettings { get; set; }
		public Apdex XhrActionApdexSettings { get; set; }
		public Apdex CustomActionApdexSettings { get; set; }
		public WaterfallSettings WaterfallSettings { get; set; }
		public MonitoringSettings MonitoringSettings { get; set; }
		public IEnumerable<UserTag> UserTags { get; set; }
		public IEnumerable<UserActionAndSessionProperties> UserActionAndSessionProperties { get; set; }
		public UserActionNamingSettings UserActionNamingSettings { get; set; }
		public IEnumerable<MetaDataCapturing> MetaDataCaptureSettings { get; set; }
		public IEnumerable<ConversionGoal> ConversionGoals { get; set; }
		public string UrlInjectionPattern { get; set; }
	}
}
