using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class BrowserPlatformsConverter : JsonEnumConverter<BrowserPlatforms>
	{
		private static readonly Dictionary<BrowserPlatforms, string> s_pairs = new Dictionary<BrowserPlatforms, string>
		{
			[BrowserPlatforms.All] = "ALL",
			[BrowserPlatforms.Desktop] = "DESKTOP",
			[BrowserPlatforms.Mobile] = "MOBILE"
		};

		protected override Dictionary<BrowserPlatforms, string> Pairs => s_pairs;

		protected override string EntityString => "browser platform";
	}
}
