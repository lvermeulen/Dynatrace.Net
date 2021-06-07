using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetSyntheticLocationsV1Async()
		{
			var result = await _client.GetSyntheticLocationsV1Async().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetSyntheticLocationV1Async()
		{
			var results = await _client.GetSyntheticLocationsV1Async().ConfigureAwait(false);
			var firstResult = results.Locations.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetSyntheticLocationV1Async(firstResult.EntityId).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
