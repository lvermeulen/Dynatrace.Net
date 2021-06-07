using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetSyntheticLocationsV2Async()
		{
			var result = await _client.GetSyntheticLocationsV2Async().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetSyntheticLocationV2Async()
		{
			var results = await _client.GetSyntheticLocationsV2Async().ConfigureAwait(false);
			var firstResult = results.Locations.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetSyntheticLocationV2Async(firstResult.EntityId).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
