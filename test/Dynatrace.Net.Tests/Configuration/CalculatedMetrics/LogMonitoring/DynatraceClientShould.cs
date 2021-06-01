using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetCalculatedLogMonitoringMetricsAsync()
		{
			var result = await _client.GetCalculatedLogMonitoringMetricsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetCalculatedLogMonitoringMetricAsync()
		{
			var results = await _client.GetCalculatedLogMonitoringMetricsAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetCalculatedLogMonitoringMetricAsync(firstResult?.Name).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
