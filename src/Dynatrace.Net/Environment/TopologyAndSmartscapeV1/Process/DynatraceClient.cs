using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Environment.ProblemsV1.Models;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private static readonly ProcessMonitoringStatesConverter s_processMonitoringStatesConverter = new ProcessMonitoringStatesConverter();

		private IFlurlRequest GetTopologyProcessUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/entity/infrastructure/processes");
		}

		public async Task<IEnumerable<ProcessGroupInstance>> GetAllTopologyProcessesAsync(int? startTimestamp = null, int? endTimestamp = null, RelativeTimes? relativeTime = null, IEnumerable<string> tag = null,
			IEnumerable<string> entity = null, IEnumerable<string> hostTag = null, IEnumerable<string> host = null, ProcessMonitoringStates? actualMonitoringState = null, 
			ProcessMonitoringStates? expectedMonitoringState = null, int? managementZone = null, bool? includeDetails = null, int? pageSize = null, string nextPageKey = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(startTimestamp)] = startTimestamp,
				[nameof(endTimestamp)] = endTimestamp,
				[nameof(relativeTime)] = relativeTime?.ToString(),
				[nameof(tag)] = tag == null ? null : string.Join("&", tag.Select(x => $"tag={x}")),
				[nameof(entity)] = entity == null ? null : string.Join("&", entity.Select(x => $"entity={x}")),
				[nameof(hostTag)] = hostTag == null ? null : string.Join("&", hostTag),
				[nameof(host)] = host == null ? null : string.Join("&", host.Select(x => $"host={x}")),
				[nameof(actualMonitoringState)] = s_processMonitoringStatesConverter.ConvertToString(actualMonitoringState),
				[nameof(expectedMonitoringState)] = s_processMonitoringStatesConverter.ConvertToString(expectedMonitoringState),
				[nameof(managementZone)] = managementZone,
				[nameof(includeDetails)] = includeDetails,
				[nameof(pageSize)] = pageSize,
				[nameof(nextPageKey)] = nextPageKey
			};

			var response = await GetTopologyProcessUrl()
				.SetQueryParams(queryParamValues)
				.GetJsonAsync<IEnumerable<ProcessGroupInstance>>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<ProcessGroupInstance> GetTopologyProcessAsync(string meIdentifier, CancellationToken cancellationToken = default)
		{
			var response = await GetTopologyProcessUrl()
				.AppendPathSegment(meIdentifier)
				.GetJsonAsync<ProcessGroupInstance>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}
