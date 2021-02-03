using System.Collections.Generic;
using Dynatrace.Net.Environment.Anonymization.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class AdditionalFieldsConverter : JsonEnumConverter<AdditionalFields>
	{
		private static readonly Dictionary<AdditionalFields, string> s_pairs = new Dictionary<AdditionalFields, string>
		{
			[AdditionalFields.Ip] = "ip",
			[AdditionalFields.Content] = "content",
			[AdditionalFields.Country] = "country",
			[AdditionalFields.Region] = "region",
			[AdditionalFields.City] = "city",
			[AdditionalFields.UserId] = "userId",
			[AdditionalFields.Isp] = "isp",
			[AdditionalFields.StringProperties] = "stringProperties",
			[AdditionalFields.LongProperties] = "longProperties",
			[AdditionalFields.DoubleProperties] = "doubleProperties",
			[AdditionalFields.DateProperties] = "dateProperties",
			[AdditionalFields.Carrier] = "carrier",
			[AdditionalFields.UserActionsName] = "userActions.name",
			[AdditionalFields.UserActionsDomain] = "userActions.domain",
			[AdditionalFields.UserActionsTargetUrl] = "userActions.targetUrl",
			[AdditionalFields.UserActionsSyntheticEvent] = "userActions.syntheticEvent",
			[AdditionalFields.UserActionsStringProperties] = "userActions.stringProperties",
			[AdditionalFields.UserActionsLongProperties] = "userActions.longProperties",
			[AdditionalFields.UserActionsDoubleProperties] = "userActions.doubleProperties",
			[AdditionalFields.UserActionsDateProperties] = "userActions.dateProperties"
		};

		protected override Dictionary<AdditionalFields, string> Pairs => s_pairs;

		protected override string EntityString => "addition field";
	}
}
