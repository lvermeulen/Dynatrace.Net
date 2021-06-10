using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.Services.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private static readonly CustomServiceTechnologiesConverter s_customServiceTechnologiesConverter = new CustomServiceTechnologiesConverter();
		private static readonly PositionsConverter s_positionsConverter = new PositionsConverter();

		private IFlurlRequest GetCustomServicesUrl(CustomServiceTechnologies technology)
		{
			return GetBaseUrl()
				.AppendPathSegment($"config/v1/service/customServices/{s_customServiceTechnologiesConverter.ConvertToString(technology)}");
		}

		public async Task<StubList> GetAllCustomServiceRulesAsync(CustomServiceTechnologies technology, CancellationToken cancellationToken = default)
		{
			var response = await GetCustomServicesUrl(technology)
				.GetJsonWithErrorCheckingAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<CustomService> GetCustomServiceRuleAsync(CustomServiceTechnologies technology, string id, bool? includeProcessGroupReferences = null, 
			CancellationToken cancellationToken = default)
		{
			var response = await GetCustomServicesUrl(technology)
				.AppendPathSegment(id)
				.SetQueryParam(nameof(includeProcessGroupReferences), includeProcessGroupReferences)
				.GetJsonWithErrorCheckingAsync<CustomService>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> CreateCustomServiceRuleAsync(CustomServiceTechnologies technology, Positions? position = null, CustomService body = null, 
			CancellationToken cancellationToken = default)
		{
			var response = await GetCustomServicesUrl(technology)
				.SetQueryParam(nameof(position), s_positionsConverter.ConvertToString(position))
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateCustomServiceRuleAsync(CustomServiceTechnologies technology, string id, CustomService body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetCustomServicesUrl(technology)
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteCustomServiceRuleAsync(CustomServiceTechnologies technology, string id, CancellationToken cancellationToken = default)
		{
			var response = await GetCustomServicesUrl(technology)
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> UpdateCustomServiceReorderRulesAsync(CustomServiceTechnologies technology, StubList body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetCustomServicesUrl(technology)
				.AppendPathSegment("order")
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
