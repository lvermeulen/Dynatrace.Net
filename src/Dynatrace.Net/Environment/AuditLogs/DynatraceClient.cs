using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
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
			var queryParamValues = new Dictionary<string, object>();
			if (nextPageKey is not null)
			{
				queryParamValues[nameof(nextPageKey)] = nextPageKey;
			}

			if (pageSize is not null)
			{
				queryParamValues[nameof(pageSize)] = pageSize;
			}

			if (filter is not null)
			{
				queryParamValues[nameof(filter)] = filter.ToString();
			}

			if (from is not null)
			{
				queryParamValues[nameof(from)] = from.ToString();
			}

			if (to is not null)
			{
				queryParamValues[nameof(to)] = to.ToString();
			}

			if (oldestFirst is not null)
			{
				queryParamValues["sort"] = oldestFirst is true ? "timestamp" : "-timestamp";
			}

			var response = await GetAuditLogsUrl()
				.SetQueryParams(queryParamValues)
				.GetJsonIfNotEmptyAsync(new AuditLog(), cancellationToken)
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
