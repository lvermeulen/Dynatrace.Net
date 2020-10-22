using System.Collections.Generic;

namespace Dynatrace.Net.Environment.Events.Models
{
	public class PushEventAttachRules
	{
		public IEnumerable<string> EntityIds { get; set; }
		public IEnumerable<TagMatchRule> TagRule { get; set; }
	}
}
