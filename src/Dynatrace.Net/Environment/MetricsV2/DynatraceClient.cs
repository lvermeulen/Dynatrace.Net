using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.MetricsV2.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetMetricsV2Url()
		{
			return GetBaseUrl()
				.AppendPathSegment("v2/metrics");
		}

		public async Task<bool> AddIngestDataPointsV2Async(string body, CancellationToken cancellationToken = default)
		{
			var response = await GetMetricsV2Url()
				.AppendPathSegment("ingest")
				.PostJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<MetricDescriptorCollection> GetAllAvailableMetricsV2Async(string nextPageKey = null, int? pageSize = null, IEnumerable<string> metricSelector = null,
			string text = null, IEnumerable<WithOrWithout<MetricFields>> fields = null, Timeframe writtenSince = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(nextPageKey)] = nextPageKey,
				[nameof(pageSize)] = pageSize,
				[nameof(metricSelector)] = string.Join(",", metricSelector ?? Enumerable.Empty<string>()),
				[nameof(text)] = text,
				[nameof(fields)] = string.Join(",", (fields ?? Enumerable.Empty<WithOrWithout<MetricFields>>())
					.Distinct()),
				[nameof(writtenSince)] = writtenSince?.ToString()
			};

			var response = await GetMetricsV2Url()
				.SetQueryParams(queryParamValues)
				.GetJsonAsync<MetricDescriptorCollection>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<MetricDescriptor> GetMetricDescriptorV2Async(string metricId, CancellationToken cancellationToken = default)
		{
			var response = await GetMetricsV2Url()
				.AppendPathSegment(metricId)
				.GetJsonAsync<MetricDescriptor>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<MetricData> GetMetricDataPointsV2Async(string nextPageKey = null, int? pageSize = null, IEnumerable<string> metricSelector = null,
			string resolution = null, Timeframe from = null, Timeframe to = null, EntitySelector entitySelector = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(nextPageKey)] = nextPageKey,
				[nameof(pageSize)] = pageSize,
				[nameof(metricSelector)] = string.Join(",", (metricSelector ?? Enumerable.Empty<string>())),
				[nameof(resolution)] = resolution,
				[nameof(from)] = from?.ToString(),
				[nameof(to)] = to?.ToString(),
				[nameof(entitySelector)] = entitySelector?.ToString()
			};

			var response = await GetMetricsV2Url()
				.AppendPathSegment("comments")
				.SetQueryParams(queryParamValues)
				.GetJsonAsync<MetricData>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}
