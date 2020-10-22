using System.Collections.Generic;
using System.Linq;
using Dynatrace.Net.Common.Extensions;

namespace Dynatrace.Net.Environment.AuditLogs.Models
{
	public class AuditLogFilter
	{
		public IEnumerable<string> User { get; set; }
		public IEnumerable<string> EventType { get; set; }
		public IEnumerable<string> Category { get; set; }
		public IEnumerable<string> EntityId { get; set; }

		public override string ToString()
		{
			return string.Join(",", new List<string>
			{
				string.Join(",", (User ?? Enumerable.Empty<string>())).WithPrefixAndParentheses("user", true),
				string.Join(",", (EventType ?? Enumerable.Empty<string>())).WithPrefixAndParentheses("eventType", true),
				string.Join(",", (Category ?? Enumerable.Empty<string>())).WithPrefixAndParentheses("category", true),
				string.Join(",", (EntityId ?? Enumerable.Empty<string>())).WithPrefixAndParentheses("entityId", true)
			});
		}
	}
}
