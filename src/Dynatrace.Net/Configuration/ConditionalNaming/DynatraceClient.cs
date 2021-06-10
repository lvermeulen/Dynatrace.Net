using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.ConditionalNaming.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private static readonly ConditionalNamingTypesConverter s_conditionalNamingTypesConverter = new ConditionalNamingTypesConverter();

		private IFlurlRequest GetConditionalNamingUrl(ConditionalNamingTypes type)
		{
			return GetBaseUrl()
				.AppendPathSegment($"config/v1/conditionalNaming/{s_conditionalNamingTypesConverter.ConvertToString(type)}");
		}

		public async Task<StubList> GetAllConditionalNamingRulesAsync(ConditionalNamingTypes type, CancellationToken cancellationToken = default)
		{
			var response = await GetConditionalNamingUrl(type)
				.GetJsonWithErrorCheckingAsync<StubList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<ConditionalNamingRule> GetConditionalNamingRuleAsync(ConditionalNamingTypes type, string id, CancellationToken cancellationToken = default)
		{
			var response = await GetConditionalNamingUrl(type)
				.AppendPathSegment(id)
				.GetJsonWithErrorCheckingAsync<ConditionalNamingRule>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityShortRepresentation> AddConditionalNamingRuleAsync(ConditionalNamingTypes type, ConditionalNamingRule body, CancellationToken cancellationToken = default)
		{
			var response = await GetConditionalNamingUrl(type)
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateConditionalNamingRuleAsync(ConditionalNamingTypes type, string id, ConditionalNamingRule body, CancellationToken cancellationToken = default)
		{
			var response = await GetConditionalNamingUrl(type)
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteConditionalNamingRuleAsync(ConditionalNamingTypes type, string id, CancellationToken cancellationToken = default)
		{
			var response = await GetConditionalNamingUrl(type)
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
