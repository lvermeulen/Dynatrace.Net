using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.ServiceLevelObjectives.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetServiceLevelObjectivesUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v2/slo");
		}

		public async Task<SloList> GetAllServiceLevelObjectivesAsync(string nextPageKey = null, int? pageSize = null, Timeframe from = null, Timeframe to = null, string sloSelector = null, bool? sortAscending = null,
			bool? demo = null, string timeFrame = null, bool? evaluate = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(nextPageKey)] = nextPageKey,
				[nameof(pageSize)] = pageSize,
				[nameof(from)] = from?.ToString(),
				[nameof(to)] = to?.ToString(),
				[nameof(sloSelector)] = sloSelector,
				["sort"] = sortAscending == true ? "name" : "-name",
				[nameof(demo)] = demo,
				[nameof(timeFrame)] = timeFrame,
				[nameof(evaluate)] = evaluate
			};

			var response = await GetServiceLevelObjectivesUrl()
				.SetQueryParams(queryParamValues)
				.GetJsonIfNotEmptyAsync(new SloList(), cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<Slo> GetServiceLevelObjectiveAsync(string id, Timeframe from = null, Timeframe to = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(from)] = from?.ToString(),
				[nameof(to)] = to?.ToString()
			};

			var response = await GetServiceLevelObjectivesUrl()
				.AppendPathSegment(id)
				.SetQueryParams(queryParamValues)
				.GetJsonAsync<Slo>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> CreateServiceLevelObjectiveAsync(SloCreate body, CancellationToken cancellationToken = default)
		{
			var response = await GetServiceLevelObjectivesUrl()
				.PostJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
