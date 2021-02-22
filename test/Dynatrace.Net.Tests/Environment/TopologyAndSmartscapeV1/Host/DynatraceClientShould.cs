using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllTopologyHostsAsync()
		{
			var result = await _client.GetAllTopologyHostsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	
		[Fact]
		public async Task GetTopologyHostAsync()
		{
			var results = await _client.GetAllTopologyHostsAsync().ConfigureAwait(false);
			var firstResult = results.FirstOrDefault();

			var result = await _client.GetTopologyHostAsync(firstResult?.EntityId).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
