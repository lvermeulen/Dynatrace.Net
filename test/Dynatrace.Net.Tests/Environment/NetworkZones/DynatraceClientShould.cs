using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task Get()
		{
			var result = await _client.GetNetworkZonesAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	
		[Fact]
		public async Task GetNetworkZoneAsync()
		{
			var results = await _client.GetNetworkZonesAsync().ConfigureAwait(false);
			var firstResult = results.NetworkZones.FirstOrDefault();

			var result = await _client.GetNetworkZoneAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	
		[Fact]
		public async Task GetNetworkZoneSettingsAsync()
		{
			var result = await _client.GetNetworkZoneSettingsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
