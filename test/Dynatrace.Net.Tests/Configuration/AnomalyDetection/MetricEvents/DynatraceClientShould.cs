using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAnomalyDetectionMetricEventRulesAsync()
		{
			var result = await _client.GetAnomalyDetectionMetricEventRulesAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetAnomalyDetectionMetricEventRuleAsync()
		{
			var results = await _client.GetAnomalyDetectionMetricEventRulesAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();

			var result = await _client.GetAnomalyDetectionMetricEventRuleAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
