using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class MonitoringSettings
	{
		public bool? FetchRequests { get; set; }
		public bool? XmlHttpRequest { get; set; }
		public JavaScriptFrameworkSupport JavaScriptFrameworkSupport { get; set; }
		public ContentCapture ContentCapture { get; set; }
		public string ExcludeXhrRegex { get; set; }
		public string CorrelationHeaderInclusionRegex { get; set; }
		[JsonConverter(typeof(InjectionModesConverter))]
		public InjectionModes? InjectionMode { get; set; }
		public bool? AddCrossOriginAnonymousAttribute { get; set; }
		public int? ScriptTagCacheDurationInHours { get; set; }
		public string LibraryFileLocation { get; set; }
		public string MonitoringDataPath { get; set; }
		public string CustomConfigurationProperties { get; set; }
		public string ServerRequestPathId { get; set; }
		public bool? SecureCookieAttribute { get; set; }
		public string CookiePlacementDomain { get; set; }
		public bool? CacheControlHeaderOptimizations { get; set; }
		public AdvancedJavaScriptTagSettings AdvancedJavaScriptTagSettings { get; set; }
		public WebApplicationConfigBrowserRestrictionSettings BrowserRestrictionSettings { get; set; }
		public WebApplicationConfigIpAddressRestrictionSettings IpAddressRestrictionSettings { get; set; }
		public IEnumerable<JavaScriptInjectionRules> JavaScriptInjectionRules { get; set; }
	}
}
