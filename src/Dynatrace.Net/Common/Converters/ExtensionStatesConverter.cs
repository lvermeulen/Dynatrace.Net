using System.Collections.Generic;
using Dynatrace.Net.Configuration.Extensions.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ExtensionStatesConverter : JsonEnumConverter<ExtensionStates>
	{
		private static readonly Dictionary<ExtensionStates, string> s_pairs = new Dictionary<ExtensionStates, string>
		{
			[ExtensionStates.Disabled] = "DISABLED",
			[ExtensionStates.ErrorAuth] = "ERROR_AUTH",
			[ExtensionStates.ErrorCommunicationFailure] = "ERROR_COMMUNICATION_FAILURE",
			[ExtensionStates.ErrorConfig] = "ERROR_CONFIG",
			[ExtensionStates.ErrorTimeout] = "ERROR_TIMEOUT",
			[ExtensionStates.ErrorUnknown] = "ERROR_UNKNOWN",
			[ExtensionStates.Incompatible] = "INCOMPATIBLE",
			[ExtensionStates.LimitReached] = "LIMIT_REACHED",
			[ExtensionStates.NothingToReport] = "NOTHING_TO_REPORT",
			[ExtensionStates.Ok] = "OK",
			[ExtensionStates.StateTypeUnknown] = "STATE_TYPE_UNKNOWN",
			[ExtensionStates.Uninitialized] = "UNINITIALIZED",
			[ExtensionStates.Unsupported] = "UNSUPPORTED",
			[ExtensionStates.WaitingForState] = "WAITING_FOR_STATE"
		};

		protected override Dictionary<ExtensionStates, string> Pairs => s_pairs;

		protected override string EntityString => "extension state";
	}
}
