using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class BrowserTypesConverter : JsonEnumConverter<BrowserTypes>
	{
		private static readonly Dictionary<BrowserTypes, string> s_pairs = new Dictionary<BrowserTypes, string>
		{
			[BrowserTypes.AndroidWebkit] = "ANDROID_WEBKIT",
			[BrowserTypes.BotsSpiders] = "BOTS_SPIDERS",
			[BrowserTypes.Chrome] = "CHROME",
			[BrowserTypes.Edge] = "EDGE",
			[BrowserTypes.Firefox] = "FIREFOX",
			[BrowserTypes.InternetExplorer] = "INTERNET_EXPLORER",
			[BrowserTypes.Opera] = "OPERA",
			[BrowserTypes.Safari] = "SAFARI"
		};

		protected override Dictionary<BrowserTypes, string> Pairs => s_pairs;

		protected override string EntityString => "browser type";
	}
}
