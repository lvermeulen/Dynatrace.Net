using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAnomalyDetectionDiskEventRulesAsync()
		{
			var result = await _client.GetAnomalyDetectionDiskEventRulesAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetAnomalyDetectionDiskEventRuleAsync()
		{
			var results = await _client.GetAnomalyDetectionDiskEventRulesAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetAnomalyDetectionDiskEventRuleAsync(firstResult.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
