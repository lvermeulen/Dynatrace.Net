using System.Collections.Generic;

namespace Dynatrace.Net.Environment.AuditLogs.Models
{
	public class AuditLog
	{
		public int? TotalCount { get; set; }
		public int? PageSize { get; set; }
		public string NextPageKey { get; set; }
		public IEnumerable<AuditLogEntry> AuditLogs { get; set; }
	}
}
