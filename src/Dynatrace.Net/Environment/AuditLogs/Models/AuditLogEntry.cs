using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.AuditLogs.Models
{
	public class AuditLogEntry
	{
		public string LogId { get; set; }
		[JsonConverter(typeof(AuditLogEventTypesConverter))]
		public AuditLogEventTypes? EventType { get; set; }
		[JsonConverter(typeof(AuditLogCategoriesConverter))]
		public AuditLogCategories? Category { get; set; }
		public string EntityId { get; set; }
		public string EnvironmentId { get; set; }
		public string User { get; set; }
		[JsonConverter(typeof(AuditLogUserTypesConverter))]
		public AuditLogUserTypes? UserType { get; set; }
		public string UserOrigin { get; set; }
		public int? Timestamp { get; set; }
		public bool? Success { get; set; }
		public string Message { get; set; }
		public object Patch { get; set; }
	}
}
