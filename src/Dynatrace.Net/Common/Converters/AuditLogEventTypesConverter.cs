using System.Collections.Generic;
using Dynatrace.Net.Environment.AuditLogs.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class AuditLogEventTypesConverter : JsonEnumConverter<AuditLogEventTypes>
	{
		private static readonly Dictionary<AuditLogEventTypes, string> s_pairs = new Dictionary<AuditLogEventTypes, string>
		{
			[AuditLogEventTypes.Create] = "CREATE",
			[AuditLogEventTypes.Delete] = "DELETE",
			[AuditLogEventTypes.General] = "GENERAL",
			[AuditLogEventTypes.Login] = "LOGIN",
			[AuditLogEventTypes.Logout] = "LOGOUT",
			[AuditLogEventTypes.Read] = "READ",
			[AuditLogEventTypes.Update] = "UPDATE"
		};

		protected override Dictionary<AuditLogEventTypes, string> Pairs => s_pairs;

		protected override string EntityString => "audit log event type";
	}
}
