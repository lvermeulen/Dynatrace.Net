using System.Collections.Generic;
using Dynatrace.Net.Configuration.Plugins.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class PluginStatesConverter : JsonEnumConverter<PluginStates>
	{
		private static readonly Dictionary<PluginStates, string> s_pairs = new Dictionary<PluginStates, string>
		{
			[PluginStates.Disabled] = "DISABLED",
			[PluginStates.ErrorAuth] = "ERROR_AUTH",
			[PluginStates.ErrorCommunicationFailure] = "ERROR_COMMUNICATION_FAILURE",
			[PluginStates.ErrorConfig] = "ERROR_CONFIG",
			[PluginStates.ErrorTimeout] = "ERROR_TIMEOUT",
			[PluginStates.ErrorUnknown] = "ERROR_UNKNOWN",
			[PluginStates.Incompatible] = "INCOMPATIBLE",
			[PluginStates.LimitReached] = "LIMIT_REACHED",
			[PluginStates.NothingToReport] = "NOTHING_TO_REPORT",
			[PluginStates.Ok] = "OK",
			[PluginStates.StateTypeUnknown] = "STATE_TYPE_UNKNOWN",
			[PluginStates.Uninitialized] = "UNINITIALIZED",
			[PluginStates.Unsupported] = "UNSUPPORTED",
			[PluginStates.WaitingForState] = "WAITING_FOR_STATE"
		};

		protected override Dictionary<PluginStates, string> Pairs => s_pairs;

		protected override string EntityString => "plugin state";
	}
}
