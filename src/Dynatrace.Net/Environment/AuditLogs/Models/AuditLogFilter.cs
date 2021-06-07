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
			var list = new List<string>();
			if (User is not null)
			{
				list.Add(string.Join(",", User ?? Enumerable.Empty<string>()).WithPrefixAndParentheses("user", true));
			}

			if (EventType is not null)
			{
				list.Add(string.Join(",", EventType ?? Enumerable.Empty<string>()).WithPrefixAndParentheses("eventType", true));
			}

			if (Category is not null)
			{
				list.Add(string.Join(",", Category ?? Enumerable.Empty<string>()).WithPrefixAndParentheses("category", true));
			}

			if (EntityId is not null)
			{
				list.Add(string.Join(",", EntityId ?? Enumerable.Empty<string>()).WithPrefixAndParentheses("entityId", true));
			}
			return string.Join(",", list);
		}
	}
}
