using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.SyntheticV1.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private static readonly SyntheticLocationV1CloudPlatformsConverter s_v1CloudPlatformsConverter = new SyntheticLocationV1CloudPlatformsConverter();
		private static readonly SyntheticLocationTypesConverter s_syntheticLocationTypesConverter = new SyntheticLocationTypesConverter();

		private IFlurlRequest GetSyntheticLocationsV1Url()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/synthetic/locations");
		}

		public async Task<SyntheticLocations> GetSyntheticLocationsV1Async(SyntheticLocationV1CloudPlatforms? cloudPlatform = null, SyntheticLocationTypes? type = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(cloudPlatform)] = s_v1CloudPlatformsConverter.ConvertToString(cloudPlatform),
				[nameof(type)] = s_syntheticLocationTypesConverter.ConvertToString(type)
			};

			var response = await GetSyntheticLocationsV1Url()
				.SetQueryParams(queryParamValues)
				.GetJsonWithErrorCheckingAsync<SyntheticLocations>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<SyntheticLocation> GetSyntheticLocationV1Async(string locationId, CancellationToken cancellationToken = default)
		{
			var response = await GetSyntheticLocationsV1Url()
				.AppendPathSegment(locationId)
				.GetJsonWithErrorCheckingAsync<SyntheticLocation>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<PrivateSyntheticLocation> CreateSyntheticLocationV1Async(PrivateSyntheticLocation body, CancellationToken cancellationToken = default)
		{
			var response = await GetSyntheticLocationsV1Url()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<PrivateSyntheticLocation>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateSyntheticLocationV1Async(string locationId, SyntheticLocationUpdate body, CancellationToken cancellationToken = default)
		{
			var response = await GetSyntheticLocationsV1Url()
				.AppendPathSegment(locationId)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteSyntheticLocationV1Async(string locationId, CancellationToken cancellationToken = default)
		{
			var response = await GetSyntheticLocationsV1Url()
				.AppendPathSegment(locationId)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}