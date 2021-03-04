using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class UserActionNamingRule
	{
		public string Template { get; set; }
		public IEnumerable<UserActionNamingRuleCondition> Conditions { get; set; }
	}
}
