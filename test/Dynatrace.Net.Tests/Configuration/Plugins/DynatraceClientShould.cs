using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllPluginsAsync()
		{
			var result = await _client.GetAllPluginsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetPluginAsync()
		{
			var results = await _client.GetAllPluginsAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetPluginAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetPluginStatesAsync()
		{
			var results = await _client.GetAllPluginsAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetPluginStatesAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetPluginEndpointsAsync()
		{
			var results = await _client.GetAllPluginsAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetPluginEndpointsAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetPluginEndpointAsync()
		{
			var results = await _client.GetAllPluginsAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var endpoints = await _client.GetPluginEndpointsAsync(firstResult?.Id).ConfigureAwait(false);
			var firstEndpoint = endpoints.Values.FirstOrDefault();
			if (firstEndpoint is null)
			{
				return;
			}

			var result = await _client.GetPluginEndpointAsync(firstResult?.Id, firstEndpoint?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetAllActiveGatePluginModulesAsync()
		{
			var result = await _client.GetAllActiveGatePluginModulesAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
