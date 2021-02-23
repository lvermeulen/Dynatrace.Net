using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.ProblemsV1.Models;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetTopologyServiceUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/entity/services");
		}

		public async Task<WithResponseHeaders<IEnumerable<Service>>> GetAllTopologyServicesAsync(int? startTimestamp = null, int? endTimestamp = null, RelativeTimes? relativeTime = null,
			IEnumerable<string> tag = null, IEnumerable<string> entity = null, int? managementZone = null, bool? includeDetails = null, int? pageSize = null, string nextPageKey = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(startTimestamp)] = startTimestamp,
				[nameof(endTimestamp)] = endTimestamp,
				[nameof(relativeTime)] = relativeTime?.ToString(),
				[nameof(tag)] = tag == null ? null : string.Join("&", tag.Select(x => $"tag={x}")),
				[nameof(entity)] = entity == null ? null : string.Join("&", entity.Select(x => $"entity={x}")),
				[nameof(managementZone)] = managementZone,
				[nameof(includeDetails)] = includeDetails,
				[nameof(pageSize)] = pageSize,
				[nameof(nextPageKey)] = nextPageKey
			};

			var response = await GetTopologyServiceUrl()
				.SetQueryParams(queryParamValues)
				.GetJsonWithResponseHeadersAsync<IEnumerable<Service>>(TopologyAndSmartscapeV1HeaderHandler.HandleTopologyAndSmartscapeV1Headers, cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<Service> GetTopologyServiceAsync(string meIdentifier, CancellationToken cancellationToken = default)
		{
			var response = await GetTopologyServiceUrl()
				.AppendPathSegment(meIdentifier)
				.GetJsonAsync<Service>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> AssignTopologyServiceCustomTagsAsync(string meIdentifier, UpdateEntity body, CancellationToken cancellationToken = default)
		{
			var response = await GetTopologyServiceUrl()
				.AppendPathSegment(meIdentifier)
				.PostJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<ServiceBaselineValues> GetTopologyServiceBaselineAsync(string meIdentifier, CancellationToken cancellationToken = default)
		{
			var response = await GetTopologyServiceUrl()
				.AppendPathSegment(meIdentifier)
				.AppendPathSegment("baseline")
				.GetJsonAsync<ServiceBaselineValues>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}
