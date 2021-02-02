using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.SyntheticV1.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private static readonly SyntheticMonitorTypesV1Converter s_syntheticMonitorTypesV1Converter = new SyntheticMonitorTypesV1Converter();

		private IFlurlRequest GetSyntheticMonitorsV1Url()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/synthetic/monitors");
		}

		public async Task<MonitorsObject> GetSyntheticMonitorsV1Async(int? managementZone = null, IEnumerable<string> tag = null, string location = null, IEnumerable<string> assignedApps = null,
			SyntheticMonitorTypesV1? type = null, bool? enabled = null, string credentialId = null, string credentialOwner = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(managementZone)] = managementZone,
				[nameof(tag)] = tag == null ? null : string.Join("&", tag.Select(x => $"tag={x}")),
				[nameof(location)] = location,
				[nameof(assignedApps)] = assignedApps == null ? null : string.Join("&", assignedApps.Select(x => $"assignedApps={x}")),
				[nameof(type)] = s_syntheticMonitorTypesV1Converter.ConvertToString(type),
				[nameof(enabled)] = enabled,
				[nameof(credentialId)] = credentialId,
				[nameof(credentialOwner)] = credentialOwner
			};

			var response = await GetSyntheticMonitorsV1Url()
				.SetQueryParams(queryParamValues)
				.GetJsonAsync<MonitorsObject>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<SyntheticMonitor> GetSyntheticMonitorV1Async(string monitorId, CancellationToken cancellationToken = default)
		{
			var response = await GetSyntheticMonitorsV1Url()
				.AppendPathSegment(monitorId)
				.GetJsonAsync<SyntheticMonitor>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EntityIdDto> CreateSyntheticMonitorV1Async(SyntheticMonitorUpdate body, CancellationToken cancellationToken = default)
		{
			var response = await GetSyntheticMonitorsV1Url()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityIdDto>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> UpdateSyntheticMonitorV1Async(string monitorId, SyntheticMonitorUpdate body, CancellationToken cancellationToken = default)
		{
			var response = await GetSyntheticMonitorsV1Url()
				.AppendPathSegment(monitorId)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteSyntheticMonitorV1Async(string monitorId, CancellationToken cancellationToken = default)
		{
			var response = await GetSyntheticMonitorsV1Url()
				.AppendPathSegment(monitorId)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}