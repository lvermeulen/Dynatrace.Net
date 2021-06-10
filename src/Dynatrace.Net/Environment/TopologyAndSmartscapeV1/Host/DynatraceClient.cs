using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Environment.ProblemsV1.Models;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetTopologyHostUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/entity/infrastructure/hosts");
		}

		public async Task<IEnumerable<Host>> GetAllTopologyHostsAsync(long? startTimestamp = null, long? endTimestamp = null, RelativeTimes? relativeTime = null, IEnumerable<string> tag = null,
			bool? showMonitoringCandidates = null, IEnumerable<string> entity = null, int? managementZone = null, string hostGroupId = null, string hostGroupName = null, bool? includeDetails = null, 
			int? pageSize = null, string nextPageKey = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(startTimestamp)] = startTimestamp,
				[nameof(endTimestamp)] = endTimestamp,
				[nameof(relativeTime)] = relativeTime?.ToString(),
				[nameof(tag)] = tag == null ? null : string.Join("&", tag.Select(x => $"tag={x}")),
				[nameof(showMonitoringCandidates)] = showMonitoringCandidates,
				[nameof(entity)] = entity == null ? null : string.Join("&", entity.Select(x => $"entity={x}")),
				[nameof(managementZone)] = managementZone,
				[nameof(hostGroupId)] = hostGroupId,
				[nameof(hostGroupName)] = hostGroupName,
				[nameof(includeDetails)] = includeDetails,
				[nameof(pageSize)] = pageSize,
				[nameof(nextPageKey)] = nextPageKey
			};

			var response = await GetTopologyHostUrl()
				.SetQueryParams(queryParamValues)
				.GetJsonWithErrorCheckingAsync<IEnumerable<Host>>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<Host> GetTopologyHostAsync(string meIdentifier, CancellationToken cancellationToken = default)
		{
			var response = await GetTopologyHostUrl()
				.AppendPathSegment(meIdentifier)
				.GetJsonWithErrorCheckingAsync<Host>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> AssignTopologyHostCustomTagsAsync(string meIdentifier, UpdateEntity body, CancellationToken cancellationToken = default)
		{
			var response = await GetTopologyHostUrl()
				.AppendPathSegment(meIdentifier)
				.PostJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
