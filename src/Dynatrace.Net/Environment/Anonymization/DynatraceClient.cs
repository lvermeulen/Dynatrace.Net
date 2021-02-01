using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.Anonymization.Models;
using Dynatrace.Net.Environment.AuditLogs.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private static readonly AdditionalFieldsConverter s_additionalFieldsConverter = new AdditionalFieldsConverter();

		private IFlurlRequest GetAnonymizationUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/anonymize/anonymizationJobs");
		}

		public async Task<AnonymizationIdResult> StartAnonymizationJobAsync(int? startTimestamp = null, int? endTimestamp = null, IEnumerable<string> userIds = null, IEnumerable<string> ips = null, IEnumerable<AdditionalFields> additionalField = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(startTimestamp)] = startTimestamp,
				[nameof(endTimestamp)] = endTimestamp,
				[nameof(userIds)] = userIds == null ? null : string.Join("&", userIds.Select(x => $"userIds={x}")),
				[nameof(ips)] = ips == null ? null : string.Join("&", ips.Select(x => $"ips={x}")),
				[nameof(additionalField)] = additionalField == null ? null : string.Join("&", additionalField.Select(x => $"additionalField={s_additionalFieldsConverter.ConvertToString(x)}"))
			};

			var response = await GetAnonymizationUrl()
				.SetQueryParams(queryParamValues)
				.PutJsonAsync(null, cancellationToken)
				.ReceiveJson<AnonymizationIdResult>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<AnonymizationProgressResult> CheckAnonymizationJobStatusAsync(string requestId, CancellationToken cancellationToken = default)
		{
			var response = await GetAnonymizationUrl()
				.AppendPathSegment(requestId)
				.GetJsonAsync<AnonymizationProgressResult>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}
