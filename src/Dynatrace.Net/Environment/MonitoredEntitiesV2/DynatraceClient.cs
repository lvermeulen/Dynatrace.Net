using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.MonitoredEntitiesV2.Models;
using Dynatrace.Net.Environment.ProblemsV2.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetMonitoredEntitiesV2Url()
		{
			return GetBaseUrl()
				.AppendPathSegment("v2/entities");
		}

		private IFlurlRequest GetMonitoredEntityTypesV2Url()
		{
			return GetBaseUrl()
				.AppendPathSegment("v2/entityTypes");
		}

		public async Task<EntitiesList> GetMonitoredEntitiesV2Async(string nextPageKey = null, int? pageSize = null, EntitySelector entitySelector = null,
			Timeframe from = null, Timeframe to = null, IEnumerable<WithOrWithout<string>> fields = null,
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

			if (entitySelector is not null)
			{
				queryParamValues[nameof(entitySelector)] = entitySelector.ToString();
			}

			if (from is not null)
			{
				queryParamValues[nameof(from)] = from.ToString();
			}

			if (to is not null)
			{
				queryParamValues[nameof(to)] = to.ToString();
			}

			if (fields is not null)
			{
				queryParamValues[nameof(fields)] = string.Join(",", fields
					.Distinct()
					.Select(x => $"+{x.ToString().ToCamelCase()}")).WithPrefixAndParentheses("fields=");
			}

			var response = await GetMonitoredEntitiesV2Url()
				.SetQueryParams(queryParamValues)
				.GetJsonIfNotEmptyAsync(new EntitiesList(), cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<Entity> GetMonitoredEntityV2Async(string entityId, Timeframe from = null, Timeframe to = null, IEnumerable<WithOrWithout<ProblemFields>> fields = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(from)] = from?.ToString(),
				[nameof(to)] = to?.ToString(),
				[nameof(fields)] = string.Join(",", (fields ?? Enumerable.Empty<WithOrWithout<ProblemFields>>())
					.Distinct()
					.Select(x => $"+{x.ToString().ToCamelCase()}"))
			};

			var response = await GetMonitoredEntitiesV2Url()
				.AppendPathSegment(entityId)
				.SetQueryParams(queryParamValues)
				.GetJsonWithErrorCheckingAsync<Entity>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityTypeList> GetMonitoredEntityTypesV2Async(string nextPageKey = null, int? pageSize = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(nextPageKey)] = nextPageKey,
				[nameof(pageSize)] = pageSize
			};

			var response = await GetMonitoredEntityTypesV2Url()
				.SetQueryParams(queryParamValues)
				.GetJsonWithErrorCheckingAsync<EntityTypeList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityType> GetMonitoredEntityTypeV2Async(string type, CancellationToken cancellationToken = default)
		{
			var response = await GetMonitoredEntityTypesV2Url()
				.AppendPathSegment(type)
				.GetJsonWithErrorCheckingAsync<EntityType>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<CustomDeviceCreationResult> AddMonitoredEntitiesCustomDeviceV2Async(CustomDeviceCreation body, CancellationToken cancellationToken = default)
		{
			var response = await GetMonitoredEntitiesV2Url()
				.AppendPathSegment("custom")
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<CustomDeviceCreationResult>()
				.ConfigureAwait(false);

			return response;
		}
	}
}
