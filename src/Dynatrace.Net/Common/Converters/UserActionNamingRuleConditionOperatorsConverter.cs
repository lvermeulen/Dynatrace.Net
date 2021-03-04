using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class UserActionNamingRuleConditionOperatorsConverter : JsonEnumConverter<UserActionNamingRuleConditionOperators>
	{
		private static readonly Dictionary<UserActionNamingRuleConditionOperators, string> s_pairs = new Dictionary<UserActionNamingRuleConditionOperators, string>
		{
			[UserActionNamingRuleConditionOperators.Contains] = "CONTAINS",
			[UserActionNamingRuleConditionOperators.EndsWith] = "ENDS_WITH",
			[UserActionNamingRuleConditionOperators.Equal] = "EQUALS",
			[UserActionNamingRuleConditionOperators.IsEmpty] = "IS_EMPTY",
			[UserActionNamingRuleConditionOperators.IsNotEmpty] = "IS_NOT_EMPTY",
			[UserActionNamingRuleConditionOperators.MatchesRegularExpression] = "MATCHES_REGULAR_EXPRESSION",
			[UserActionNamingRuleConditionOperators.NotContains] = "NOT_CONTAINS",
			[UserActionNamingRuleConditionOperators.NotEndsWith] = "NOT_ENDS_WITH",
			[UserActionNamingRuleConditionOperators.NotEquals] = "NOT_EQUALS",
			[UserActionNamingRuleConditionOperators.NotMatchesRegularExpression] = "NOT_MATCHES_REGULAR_EXPRESSION",
			[UserActionNamingRuleConditionOperators.NotStartsWith] = "NOT_STARTS_WITH",
			[UserActionNamingRuleConditionOperators.StartsWith] = "STARTS_WITH"
		};

		protected override Dictionary<UserActionNamingRuleConditionOperators, string> Pairs => s_pairs;

		protected override string EntityString => "operator";
	}
}
