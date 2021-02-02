using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Environment.SyntheticV1.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetSyntheticThirdPartyMonitorsV1Url()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/synthetic/ext");
		}

		public async Task<bool> CreateSyntheticThirdPartyMonitorsV1Async(ThirdPartySyntheticTests body, CancellationToken cancellationToken = default)
		{
			var response = await GetSyntheticThirdPartyMonitorsV1Url()
				.AppendPathSegment("tests")
				.PostJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> CreateSyntheticThirdPartyEventsV1Async(ThirdPartySyntheticEvents body, CancellationToken cancellationToken = default)
		{
			var response = await GetSyntheticThirdPartyMonitorsV1Url()
				.AppendPathSegment("events")
				.PostJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> ModifySyntheticThirdPartyMonitorsStateV1Async(StateModifications body, CancellationToken cancellationToken = default)
		{
			var response = await GetSyntheticThirdPartyMonitorsV1Url()
				.AppendPathSegment("stateModifications")
				.PostJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}