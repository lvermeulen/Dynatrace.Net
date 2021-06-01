using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetMaintenanceWindowsAsync()
		{
			var result = await _client.GetMaintenanceWindowsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetMaintenanceWindowAsync()
		{
			var results = await _client.GetMaintenanceWindowsAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetMaintenanceWindowAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
