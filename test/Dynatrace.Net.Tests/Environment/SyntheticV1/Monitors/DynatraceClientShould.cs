using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetSyntheticMonitorsV1Async()
		{
			var result = await _client.GetSyntheticMonitorsV1Async().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetSyntheticMonitorV1Async()
		{
			var results = await _client.GetSyntheticMonitorsV1Async().ConfigureAwait(false);
			var firstResult = results.Monitors.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetSyntheticMonitorV1Async(firstResult?.EntityId).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
