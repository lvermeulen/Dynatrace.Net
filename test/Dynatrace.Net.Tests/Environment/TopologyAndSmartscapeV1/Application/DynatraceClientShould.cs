using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllTopologyAppsAsync()
		{
			var result = await _client.GetAllTopologyAppsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	
		[Fact]
		public async Task GetTopologyAppAsync()
		{
			var results = await _client.GetAllTopologyAppsAsync().ConfigureAwait(false);
			var firstResult = results.Instance.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetTopologyAppAsync(firstResult?.EntityId).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	
		[Fact]
		public async Task GetTopologyAppBaselineAsync()
		{
			var results = await _client.GetAllTopologyAppsAsync().ConfigureAwait(false);
			var firstResult = results.Instance.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetTopologyAppBaselineAsync(firstResult?.EntityId).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
