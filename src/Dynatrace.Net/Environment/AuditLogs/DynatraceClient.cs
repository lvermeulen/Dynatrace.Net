using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.AuditLogs.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetAuditLogsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v2/auditlogs");
		}

		public async Task<AuditLog> GetAuditLogAsync(string nextPageKey = null, int? pageSize = null, AuditLogFilter filter = null, Timeframe from = null, Timeframe to = null, bool? oldestFirst = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(nextPageKey)] = nextPageKey,
				[nameof(pageSize)] = pageSize,
				[nameof(filter)] = filter?.ToString(),
				[nameof(from)] = from?.ToString(),
				[nameof(to)] = to?.ToString(),
				["sort"] = oldestFirst.HasValue && oldestFirst == true ? "timestamp" : "-timestamp"
			};

			var response = await GetAuditLogsUrl()
				.SetQueryParams(queryParamValues)
				.GetJsonAsync<AuditLog>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<AuditLogEntry> GetAuditLogEntryAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetAuditLogsUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<AuditLogEntry>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}
