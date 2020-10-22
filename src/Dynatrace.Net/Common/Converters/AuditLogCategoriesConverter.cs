using System.Collections.Generic;
using Dynatrace.Net.Environment.AuditLogs.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class AuditLogCategoriesConverter : JsonEnumConverter<AuditLogCategories>
	{
		private static readonly Dictionary<AuditLogCategories, string> s_pairs = new Dictionary<AuditLogCategories, string>
		{
			[AuditLogCategories.Config] = "CONFIG",
			[AuditLogCategories.DebugUi] = "DEBUG_UI",
			[AuditLogCategories.Token] = "TOKEN",
			[AuditLogCategories.WebUi] = "WEB_UI"
		};

		protected override Dictionary<AuditLogCategories, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "audit log category";
	}
}
