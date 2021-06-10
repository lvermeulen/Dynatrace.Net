using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.ActiveGates.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private static readonly ActiveGatesOsTypesConverter s_activeGatesOsTypesConverter = new ActiveGatesOsTypesConverter();
		private static readonly ActiveGatesTypesConverter s_activeGatesTypesConverter = new ActiveGatesTypesConverter();
		private static readonly ActiveGatesUpdateStatusTypesConverter s_activeGatesUpdateStatusTypesConverter = new ActiveGatesUpdateStatusTypesConverter();
		private static readonly VersionCompareTypesConverter s_versionCompareTypesConverter = new VersionCompareTypesConverter();
		private static readonly AutoUpdateJobUpdateTypesConverter s_autoUpdateJobUpdateTypesConverter = new AutoUpdateJobUpdateTypesConverter();

		private IFlurlRequest GetActiveGatesUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v2/activeGates");
		}

		private IFlurlRequest GetActiveGatesAutoUpdateJobsUrl(string agId)
		{
			return GetActiveGatesUrl()
				.AppendPathSegment(agId)
				.AppendPathSegment("updateJobs");
		}

		public async Task<ActiveGateList> GetActiveGatesAsync(string hostname = null, ActiveGatesOsTypes? osType = null, string networkAddress = null, ActiveGatesTypes? type = null, string networkZone = null,
			ActiveGatesUpdateStatusTypes? updateStatus = null, VersionCompareTypes? versionCompareType = null, string version = null, string group = null, bool? online = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(hostname)] = hostname,
				[nameof(osType)] = s_activeGatesOsTypesConverter.ConvertToString(osType),
				[nameof(networkAddress)] = networkAddress,
				[nameof(type)] = s_activeGatesTypesConverter.ConvertToString(type),
				[nameof(networkZone)] = networkZone,
				[nameof(updateStatus)] = s_activeGatesUpdateStatusTypesConverter.ConvertToString(updateStatus),
				[nameof(versionCompareType)] = s_versionCompareTypesConverter.ConvertToString(versionCompareType),
				[nameof(version)] = version,
				[nameof(group)] = group,
				[nameof(online)] = online
			};

			var response = await GetActiveGatesUrl()
				.SetQueryParams(queryParamValues)
				.GetJsonWithErrorCheckingAsync<ActiveGateList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<ActiveGate> GetActiveGateAsync(string agId, CancellationToken cancellationToken = default)
		{
			var response = await GetActiveGatesUrl()
				.AppendPathSegment(agId)
				.GetJsonWithErrorCheckingAsync<ActiveGate>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<UpdateJobList> GetAutoUpdateJobsAsync(string agId, Timeframe from = null, Timeframe to = null, VersionCompareTypes? startVersionCompareType = null, string startVersion = null,
			AutoUpdateJobUpdateTypes? updateType = null, VersionCompareTypes? targetVersionCompareType = null, string targetVersion = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(from)] = from?.ToString(),
				[nameof(to)] = to?.ToString(),
				[nameof(startVersionCompareType)] = s_versionCompareTypesConverter.ConvertToString(startVersionCompareType),
				[nameof(startVersion)] = startVersion,
				[nameof(updateType)] = s_autoUpdateJobUpdateTypesConverter.ConvertToString(updateType),
				[nameof(targetVersionCompareType)] = s_versionCompareTypesConverter.ConvertToString(targetVersionCompareType),
				[nameof(targetVersion)] = targetVersion
			};

			var response = await GetActiveGatesAutoUpdateJobsUrl(agId)
				.SetQueryParams(queryParamValues)
				.GetJsonWithErrorCheckingAsync<UpdateJobList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<UpdateJob> GetAutoUpdateJobAsync(string agId, string jobId, CancellationToken cancellationToken = default)
		{
			var response = await GetActiveGatesAutoUpdateJobsUrl(agId)
				.AppendPathSegment(jobId)
				.GetJsonWithErrorCheckingAsync<UpdateJob>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<UpdateJobsAll> GetActiveGatesWithAutoUpdateJobsAsync(Timeframe from = null, Timeframe to = null, VersionCompareTypes? startVersionCompareType = null, string startVersion = null,
			AutoUpdateJobUpdateTypes? updateType = null, VersionCompareTypes? targetVersionCompareType = null, string targetVersion = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(from)] = from?.ToString(),
				[nameof(to)] = to?.ToString(),
				[nameof(startVersionCompareType)] = s_versionCompareTypesConverter.ConvertToString(startVersionCompareType),
				[nameof(startVersion)] = startVersion,
				[nameof(updateType)] = s_autoUpdateJobUpdateTypesConverter.ConvertToString(updateType),
				[nameof(targetVersionCompareType)] = s_versionCompareTypesConverter.ConvertToString(targetVersionCompareType),
				[nameof(targetVersion)] = targetVersion
			};

			var response = await GetActiveGatesUrl()
				.AppendPathSegment("updateJobs")
				.SetQueryParams(queryParamValues)
				.GetJsonWithErrorCheckingAsync<UpdateJobsAll>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<UpdateJob> CreateAutoUpdateJobAsync(string agId, UpdateJob body, CancellationToken cancellationToken = default)
		{
			var response = await GetActiveGatesAutoUpdateJobsUrl(agId)
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<UpdateJob>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> DeleteAutoUpdateJobAsync(string agId, string jobId, CancellationToken cancellationToken = default)
		{
			var response = await GetActiveGatesAutoUpdateJobsUrl(agId)
				.AppendPathSegment(jobId)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
