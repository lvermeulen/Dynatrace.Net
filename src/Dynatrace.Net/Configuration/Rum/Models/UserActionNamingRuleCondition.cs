using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class UserActionNamingRuleCondition
	{
		public string Operand1	{get;set;}
		public string Operand2	{get;set;}
		[JsonConverter(typeof(UserActionNamingRuleConditionOperatorsConverter))]
		public UserActionNamingRuleConditionOperators? Operator	{get;set;}
	}
}
