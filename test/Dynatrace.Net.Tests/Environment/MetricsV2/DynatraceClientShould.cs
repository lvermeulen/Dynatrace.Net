using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllAvailableMetricsV2Async()
		{
			var result = await _client.GetAllAvailableMetricsV2Async().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetMetricDescriptorV2Async()
		{
			var results = await _client.GetAllAvailableMetricsV2Async().ConfigureAwait(false);
			var firstResult = results.Metrics.FirstOrDefault();

			var result = await _client.GetMetricDescriptorV2Async(firstResult?.MetricId).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetMetricDataPointsV2Async()
		{
			var result = await _client.GetMetricDataPointsV2Async().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
