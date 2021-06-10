using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.MetricsV2.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private static readonly MetricResultFormatsConverter s_metricResultFormatsConverter = new MetricResultFormatsConverter();

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

		public async Task<MetricDescriptorCollection> GetAllAvailableMetricsV2Async(MetricResultFormats? resultFormat = null, string nextPageKey = null, int? pageSize = null, IEnumerable<string> metricSelector = null,
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
				.WithHeader("Accept", s_metricResultFormatsConverter.ConvertToString(resultFormat ?? MetricResultFormats.ApplicationJson))
				.SetQueryParams(queryParamValues)
				.GetJsonWithErrorCheckingAsync<MetricDescriptorCollection>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<MetricDescriptor> GetMetricDescriptorV2Async(string metricId, MetricResultFormats? resultFormat = null, CancellationToken cancellationToken = default)
		{
			var response = await GetMetricsV2Url()
				.WithHeader("Accept", s_metricResultFormatsConverter.ConvertToString(resultFormat ?? MetricResultFormats.ApplicationJson))
				.AppendPathSegment(metricId)
				.GetJsonWithErrorCheckingAsync<MetricDescriptor>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<MetricData> GetMetricDataPointsV2Async(MetricResultFormats? resultFormat = null, string nextPageKey = null, int? pageSize = null, IEnumerable<string> metricSelector = null,
			string resolution = null, Timeframe from = null, Timeframe to = null, EntitySelector entitySelector = null, CancellationToken cancellationToken = default)
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

			if (metricSelector is not null)
			{
				queryParamValues[nameof(metricSelector)] = string.Join(",", metricSelector);
			}

			if (resolution is not null)
			{
				queryParamValues[nameof(resolution)] = resolution;
			}

			if (from is not null)
			{
				queryParamValues[nameof(from)] = from.ToString();
			}

			if (to is not null)
			{
				queryParamValues[nameof(to)] = to.ToString();
			}

			if (entitySelector is not null)
			{
				queryParamValues[nameof(entitySelector)] = entitySelector.ToString();
			}

			var response = await GetMetricsV2Url()
				.WithHeader("Accept", s_metricResultFormatsConverter.ConvertToString(resultFormat ?? MetricResultFormats.ApplicationJson))
				.SetQueryParams(queryParamValues)
				.GetJsonWithErrorCheckingAsync<MetricData>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}
	}
}
