using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Environment.MetricsV2.Models;
using Dynatrace.Net.Environment.ProblemsV1.Models;
using Dynatrace.Net.Environment.TimeSeriesV1.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private static readonly TimeSeriesSourcesConverter s_timeSeriesSourcesConverter = new TimeSeriesSourcesConverter();
		private static readonly MetricDescriptorAggregationTypesConverter s_metricDescriptorAggregationTypesConverter = new MetricDescriptorAggregationTypesConverter();
		private static readonly TimeSeriesQueryModesConverter s_timeSeriesQueryModesConverter = new TimeSeriesQueryModesConverter();

		private IFlurlRequest GetTimeSeriesV1Url()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/timeseries");
		}

		public async Task<IEnumerable<TimeSeriesDefinition>> GetTimeSeriesMetricsV1Async(TimeSeriesSources? source = null, string detailedSource = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(source)] = s_timeSeriesSourcesConverter.ConvertToString(source),
				[nameof(detailedSource)] = detailedSource
			};

			var response = await GetTimeSeriesV1Url()
				.SetQueryParams(queryParamValues)
				.GetJsonWithErrorCheckingAsync<IEnumerable<TimeSeriesDefinition>>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<TimeSeriesQueryResult> GetTimeSeriesMetricV1Async(string timeseriesId, bool? includeData = null, CancellationToken cancellationToken = default)
		{
			var response = await GetTimeSeriesV1Url()
				.AppendPathSegment(timeseriesId)
				.SetQueryParam(nameof(includeData), includeData)
				.GetJsonWithErrorCheckingAsync<TimeSeriesQueryResult>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<TimeSeriesQueryResult> GetTimeSeriesDataPointsV1Async(string timeseriesId, bool? includeData = null, MetricDescriptorAggregationTypes? aggregationType = null,
			long? startTimestamp = null, long? endTimestamp = null, bool? predict = null, RelativeTimes? relativeTime = null, TimeSeriesQueryModes? queryMode = null,
			IEnumerable<string> entity = null, IEnumerable<string> tag = null, int? percentile = null, bool? includeParentIds = null, bool? considerMaintenanceWindowsForAvailability = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(includeData)] = includeData,
				[nameof(aggregationType)] = s_metricDescriptorAggregationTypesConverter.ConvertToString(aggregationType),
				[nameof(startTimestamp)] = startTimestamp,
				[nameof(endTimestamp)] = endTimestamp,
				[nameof(predict)] = predict,
				[nameof(relativeTime)] = relativeTime.ToString(),
				[nameof(queryMode)] = s_timeSeriesQueryModesConverter.ConvertToString(queryMode),
				[nameof(entity)] = entity == null ? null : string.Join("&", entity.Select(x => $"entity={x}")),
				[nameof(tag)] = tag == null ? null : string.Join("&", tag.Select(x => $"tag={x}")),
				[nameof(percentile)] = percentile,
				[nameof(includeParentIds)] = includeParentIds,
				[nameof(considerMaintenanceWindowsForAvailability)] = considerMaintenanceWindowsForAvailability
			};

			var response = await GetTimeSeriesV1Url()
				.AppendPathSegment(timeseriesId)
				.SetQueryParams(queryParamValues)
				.GetJsonWithErrorCheckingAsync<TimeSeriesQueryResult>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<TimeSeriesQueryResultWrapper> PostTimeSeriesDataPointsV1Async(string timeseriesId, TimeSeriesQueryMessage body, CancellationToken cancellationToken = default)
		{
			var response = await GetTimeSeriesV1Url()
				.AppendPathSegment(timeseriesId)
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<TimeSeriesQueryResultWrapper>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<TimeSeriesDefinition> PutTimeSeriesCustomMetricV1Async(string timeseriesId, TimeSeriesRegistrationMessage body, CancellationToken cancellationToken = default)
		{
			var response = await GetTimeSeriesV1Url()
				.AppendPathSegment(timeseriesId)
				.PutJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<TimeSeriesDefinition>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> DeleteTimeSeriesCustomMetricV1Async(string timeseriesId, CancellationToken cancellationToken = default)
		{
			var response = await GetTimeSeriesV1Url()
				.AppendPathSegment(timeseriesId)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
