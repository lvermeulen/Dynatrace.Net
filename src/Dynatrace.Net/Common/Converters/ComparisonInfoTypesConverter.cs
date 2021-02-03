using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ComparisonInfoTypesConverter : JsonEnumConverter<ComparisonInfoTypes>
	{
		private static readonly Dictionary<ComparisonInfoTypes, string> s_pairs = new Dictionary<ComparisonInfoTypes, string>
		{
			[ComparisonInfoTypes.Boolean] = "BOOLEAN",
			[ComparisonInfoTypes.EsbInputNodeType] = "ESB_INPUT_NODE_TYPE",
			[ComparisonInfoTypes.FailedState] = "FAILED_STATE",
			[ComparisonInfoTypes.FailureReason] = "FAILURE_REASON",
			[ComparisonInfoTypes.FastString] = "FAST_STRING",
			[ComparisonInfoTypes.FlawState] = "FLAW_STATE",
			[ComparisonInfoTypes.HttpMethod] = "HTTP_METHOD",
			[ComparisonInfoTypes.HttpStatusClass] = "HTTP_STATUS_CLASS",
			[ComparisonInfoTypes.IibInputNodeType] = "IIB_INPUT_NODE_TYPE",
			[ComparisonInfoTypes.Number] = "NUMBER",
			[ComparisonInfoTypes.NumberRequestAttribute] = "NUMBER_REQUEST_ATTRIBUTE",
			[ComparisonInfoTypes.ServiceType] = "SERVICE_TYPE",
			[ComparisonInfoTypes.String] = "STRING",
			[ComparisonInfoTypes.StringRequestAttribute] = "STRING_REQUEST_ATTRIBUTE",
			[ComparisonInfoTypes.Tag] = "TAG",
			[ComparisonInfoTypes.ZosCallType] = "ZOS_CALL_TYPE"
		};

		protected override Dictionary<ComparisonInfoTypes, string> Pairs => s_pairs;

		protected override string EntityString => "comparison info type";
	}
}
