using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetCalculatedMobileAppsMetricsAsync()
		{
			var result = await _client.GetCalculatedMobileAppsMetricsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetCalculatedMobileAppsMetricAsync()
		{
			var results = await _client.GetCalculatedMobileAppsMetricsAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetCalculatedMobileAppsMetricAsync(firstResult?.Name).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
