using System.Collections.Generic;
using Dynatrace.Net.Environment.AuditLogs.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class AuditLogUserTypesConverter : JsonEnumConverter<AuditLogUserTypes>
	{
		private static readonly Dictionary<AuditLogUserTypes, string> s_pairs = new Dictionary<AuditLogUserTypes, string>
		{
			[AuditLogUserTypes.PublicTokenIdentifier] = "PUBLIC_TOKEN_IDENTIFIER",
			[AuditLogUserTypes.RequestId] = "REQUEST_ID",
			[AuditLogUserTypes.ServiceName] = "SERVICE_NAME",
			[AuditLogUserTypes.TokenHash] = "TOKEN_HASH",
			[AuditLogUserTypes.UserName] = "USER_NAME"
		};

		protected override Dictionary<AuditLogUserTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "audit log user type";
	}
}
