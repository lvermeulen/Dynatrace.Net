using System.Collections.Generic;
using Dynatrace.Net.Environment.OneAgentOnAHost.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class AutoUpdateSettingsConverter : JsonEnumConverter<AutoUpdateSettings>
	{
		private static readonly Dictionary<AutoUpdateSettings, string> s_pairs = new Dictionary<AutoUpdateSettings, string>
		{
			[AutoUpdateSettings.Enabled] = "ENABLED",
			[AutoUpdateSettings.Disabled] = "DISABLED"
		};

		protected override Dictionary<AutoUpdateSettings, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "auto-update setting";
	}
}
