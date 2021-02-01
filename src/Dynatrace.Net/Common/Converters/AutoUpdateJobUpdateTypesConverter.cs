using System.Collections.Generic;
using Dynatrace.Net.Environment.ActiveGates.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class AutoUpdateJobUpdateTypesConverter : JsonEnumConverter<AutoUpdateJobUpdateTypes>
	{
		private static readonly Dictionary<AutoUpdateJobUpdateTypes, string> s_pairs = new Dictionary<AutoUpdateJobUpdateTypes, string>
		{
			[AutoUpdateJobUpdateTypes.ActiveGate] = "ACTIVE_GATE",
			[AutoUpdateJobUpdateTypes.RemotePluginAgent] = "REMOTE_PLUGIN_AGENT",
			[AutoUpdateJobUpdateTypes.Synthetic] = "SYNTHETIC",
			[AutoUpdateJobUpdateTypes.ZRemote] = "Z_REMOTE"
		};

		protected override Dictionary<AutoUpdateJobUpdateTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "update type";
	}
}
