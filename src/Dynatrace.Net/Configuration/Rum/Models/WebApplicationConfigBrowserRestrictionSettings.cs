using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class WebApplicationConfigBrowserRestrictionSettings
	{
		[JsonConverter(typeof(IpAddressModesConverter))]
		public IpAddressModes? Mode { get; set; }
		public IEnumerable<WebApplicationConfigBrowserRestriction> BrowserRestrictions { get; set; }
	}
}
