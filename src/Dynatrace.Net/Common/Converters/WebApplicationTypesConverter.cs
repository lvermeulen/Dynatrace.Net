using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class WebApplicationTypesConverter : JsonEnumConverter<WebApplicationTypes>
	{
		private static readonly Dictionary<WebApplicationTypes, string> s_pairs = new Dictionary<WebApplicationTypes, string>
		{
			[WebApplicationTypes.AutoInjected] = "AUTO_INJECTED",
			[WebApplicationTypes.BrowserExtensionInjected] = "BROWSER_EXTENSION_INJECTED",
			[WebApplicationTypes.ManuallyInjected] = "MANUALLY_INJECTED"
		};

		protected override Dictionary<WebApplicationTypes, string> Pairs => s_pairs;

		protected override string EntityString => "web application type";
	}
}
