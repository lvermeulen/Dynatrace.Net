using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllTopologyProcessesAsync()
		{
			var result = await _client.GetAllTopologyProcessesAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	
		[Fact]
		public async Task GetTopologyProcessAsync()
		{
			var results = await _client.GetAllTopologyProcessesAsync().ConfigureAwait(false);
			var firstResult = results.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetTopologyProcessAsync(firstResult.EntityId).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
