using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetSyntheticNodesV2Async()
		{
			var result = await _client.GetSyntheticNodesV2Async().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetSyntheticNodeV2Async()
		{
			var results = await _client.GetSyntheticNodesV2Async().ConfigureAwait(false);
			var firstResult = results.Nodes.FirstOrDefault();

			var result = await _client.GetSyntheticNodeV2Async(firstResult?.EntityId).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
