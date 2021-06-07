using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetTimeSeriesMetricsV1Async()
		{
			var result = await _client.GetTimeSeriesMetricsV1Async().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetTimeSeriesMetricV1Async()
		{
			var results = await _client.GetTimeSeriesMetricsV1Async().ConfigureAwait(false);
			var firstResult = results.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetTimeSeriesMetricV1Async(firstResult.TimeseriesId).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetTimeSeriesDataPointsV1Async()
		{
			var results = await _client.GetTimeSeriesMetricsV1Async().ConfigureAwait(false);
			var firstResult = results.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetTimeSeriesDataPointsV1Async(firstResult.TimeseriesId).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
