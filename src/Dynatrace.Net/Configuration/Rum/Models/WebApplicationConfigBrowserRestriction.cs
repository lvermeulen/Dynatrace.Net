using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class WebApplicationConfigBrowserRestriction
	{
		public string BrowserVersion { get; set; }
		[JsonConverter(typeof(BrowserTypesConverter))]
		public BrowserTypes? BrowserType { get; set; }
		[JsonConverter(typeof(BrowserPlatformsConverter))]
		public BrowserPlatforms? Platform { get; set; }
		[JsonConverter(typeof(BrowserComparatorsConverter))]
		public BrowserComparators? Comparator { get; set; }
	}
}
