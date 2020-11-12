using System.Collections.Generic;
using Dynatrace.Net.Environment.MonitoredEntitiesV2.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MessageTypesConverter : JsonEnumConverter<MessageTypes>
	{
		private static readonly Dictionary<MessageTypes, string> s_pairs = new Dictionary<MessageTypes, string>
		{
			[MessageTypes.CustomDevice] = "CUSTOM_DEVICE",
			[MessageTypes.FilterValueSuggestions] = "FILTER_VALUE_SUGGESTIONS",
			[MessageTypes.Multi] = "MULTI",
			[MessageTypes.MultiType] = "MULTI_TYPE",
			[MessageTypes.Single] = "SINGLE",
			[MessageTypes.SingleType] = "SINGLE_TYPE"
		};

		protected override Dictionary<MessageTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "message type";
	}
}
