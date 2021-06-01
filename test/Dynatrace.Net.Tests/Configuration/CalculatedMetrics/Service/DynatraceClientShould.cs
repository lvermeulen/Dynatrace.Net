using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetCalculatedServiceMetricsAsync()
		{
			var result = await _client.GetCalculatedServiceMetricsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetCalculatedServiceMetricAsync()
		{
			var results = await _client.GetCalculatedServiceMetricsAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetCalculatedServiceMetricAsync(firstResult?.Name).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
