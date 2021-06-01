using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetCalculatedRumMetricsAsync()
		{
			var result = await _client.GetCalculatedRumMetricsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetCalculatedRumMetricAsync()
		{
			var results = await _client.GetCalculatedRumMetricsAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetCalculatedRumMetricAsync(firstResult?.Name).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
