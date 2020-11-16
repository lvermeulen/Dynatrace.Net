using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Environment.UserSessions.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetUserSessionsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/userSessionQueryLanguage");
		}

		public async Task<DtaqlResultAsTable> GetUserSessionsAsTableAsync(string query, int? startTimestamp = null, int? endTimestamp = null, int? offsetUtc = null, int? pageSize = null,
			int? pageOffset = null, bool? addDeepLinkFields = null, bool? explain = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(query)] = query,
				[nameof(startTimestamp)] = startTimestamp,
				[nameof(endTimestamp)] = endTimestamp,
				["offsetUTC"] = offsetUtc,
				[nameof(pageSize)] = pageSize,
				[nameof(pageOffset)] = pageOffset,
				[nameof(addDeepLinkFields)] = addDeepLinkFields,
				[nameof(explain)] = explain
			};

			var response = await GetUserSessionsUrl()
				.AppendPathSegment("table")
				.SetQueryParams(queryParamValues)
				.GetJsonAsync<DtaqlResultAsTable>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<DtaqlResultAsTree> GetUserSessionsAsTreeAsync(string query, int? startTimestamp = null, int? endTimestamp = null, int? offsetUtc = null, 
			bool? addDeepLinkFields = null, bool? explain = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(query)] = query,
				[nameof(startTimestamp)] = startTimestamp,
				[nameof(endTimestamp)] = endTimestamp,
				["offsetUTC"] = offsetUtc,
				[nameof(addDeepLinkFields)] = addDeepLinkFields,
				[nameof(explain)] = explain
			};

			var response = await GetUserSessionsUrl()
				.AppendPathSegment("tree")
				.SetQueryParams(queryParamValues)
				.GetJsonAsync<DtaqlResultAsTree>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}
