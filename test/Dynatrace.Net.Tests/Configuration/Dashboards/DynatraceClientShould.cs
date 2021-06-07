using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetDashboardsAsync()
		{
			var result = await _client.GetDashboardsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetDashboardAsync()
		{
			var results = await _client.GetDashboardsAsync().ConfigureAwait(false);
			var firstResult = results.Dashboards.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetDashboardAsync(firstResult.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
