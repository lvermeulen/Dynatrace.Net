using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetSyntheticNodesV1Async()
		{
			var result = await _client.GetSyntheticNodesV1Async().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetSyntheticNodeV1Async()
		{
			var results = await _client.GetSyntheticNodesV1Async().ConfigureAwait(false);
			var firstResult = results.Nodes.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetSyntheticNodeV1Async(firstResult?.EntityId).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
