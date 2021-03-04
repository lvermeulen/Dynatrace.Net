using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class UserActionNamingSettings
	{
		public IEnumerable<UserActionNamingPlaceholder> Placeholders { get; set; }
		public IEnumerable<UserActionNamingRule> LoadActionNamingRules { get; set; }
		public IEnumerable<UserActionNamingRule> XhrActionNamingRules { get; set; }
		public IEnumerable<UserActionNamingRule> CustomActionNamingRules { get; set; }
		public bool? IgnoreCase { get; set; }
		public bool? UseFirstDetectedLoadAction { get; set; }
		public bool? SplitUserActionsByDomain { get; set; }
	}
}
