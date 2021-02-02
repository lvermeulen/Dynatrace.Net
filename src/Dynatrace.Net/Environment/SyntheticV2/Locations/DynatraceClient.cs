using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.SyntheticV2.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private static readonly SyntheticLocationV2CloudPlatformsConverter s_v2CloudPlatformsConverter = new SyntheticLocationV2CloudPlatformsConverter();

		private IFlurlRequest GetSyntheticLocationsV2Url()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/synthetic/locations");
		}

		public async Task<SyntheticLocations> GetSyntheticLocationsV2Async(SyntheticLocationV2CloudPlatforms? cloudPlatform = null, SyntheticLocationTypes? type = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(cloudPlatform)] = s_v2CloudPlatformsConverter.ConvertToString(cloudPlatform),
				[nameof(type)] = s_syntheticLocationTypesConverter.ConvertToString(type)
			};

			var response = await GetSyntheticLocationsV2Url()
				.SetQueryParams(queryParamValues)
				.GetJsonAsync<SyntheticLocations>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<SyntheticLocation> GetSyntheticLocationV2Async(string locationId, CancellationToken cancellationToken = default)
		{
			var response = await GetSyntheticLocationsV2Url()
				.AppendPathSegment(locationId)
				.GetJsonAsync<SyntheticLocation>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<SyntheticLocationIdsDto> CreateSyntheticLocationV2Async(PrivateSyntheticLocation body, CancellationToken cancellationToken = default)
		{
			var response = await GetSyntheticLocationsV2Url()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<SyntheticLocationIdsDto>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateSyntheticLocationV2Async(string locationId, SyntheticLocationUpdate body, CancellationToken cancellationToken = default)
		{
			var response = await GetSyntheticLocationsV2Url()
				.AppendPathSegment(locationId)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteSyntheticLocationV2Async(string locationId, CancellationToken cancellationToken = default)
		{
			var response = await GetSyntheticLocationsV2Url()
				.AppendPathSegment(locationId)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}