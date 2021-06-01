using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllTopologyServicesAsync()
		{
			var result = await _client.GetAllTopologyServicesAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	
		[Fact]
		public async Task GetTopologyGetAllTopologyServiceAsync()
		{
			var results = await _client.GetAllTopologyServicesAsync().ConfigureAwait(false);
			var firstResult = results.Instance.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetTopologyServiceAsync(firstResult?.EntityId).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	
		[Fact]
		public async Task GetTopologyServiceBaselineAsync()
		{
			var results = await _client.GetAllTopologyServicesAsync().ConfigureAwait(false);
			var firstResult = results.Instance.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetTopologyServiceBaselineAsync(firstResult?.EntityId).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
