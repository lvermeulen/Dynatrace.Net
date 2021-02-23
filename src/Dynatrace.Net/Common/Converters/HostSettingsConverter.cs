using System.Collections.Generic;
using Dynatrace.Net.Configuration.OneAgentOnAHost.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class HostSettingsConverter : JsonEnumConverter<HostSettings>
	{
		private static readonly Dictionary<HostSettings, string> s_pairs = new Dictionary<HostSettings, string>
		{
			[HostSettings.Enabled] = "ENABLED",
			[HostSettings.Disabled] = "DISABLED",
			[HostSettings.Inherited] = "INHERITED"
		};

		protected override Dictionary<HostSettings, string> Pairs => s_pairs;

		protected override string EntityString => "setting";
	}
}
