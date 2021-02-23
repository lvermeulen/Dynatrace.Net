using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetOneAgentOnAHostConfigAsync()
		{
			var results = await _client.GetAllTopologyHostsAsync().ConfigureAwait(false);
			var firstResult = results.FirstOrDefault();

			var result = await _client.GetOneAgentOnAHostConfigAsync(firstResult?.EntityId).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetOneAgentOnAHostAutoUpdateConfigAsync()
		{
			var results = await _client.GetAllTopologyHostsAsync().ConfigureAwait(false);
			var firstResult = results.FirstOrDefault();

			var result = await _client.GetOneAgentOnAHostAutoUpdateConfigAsync(firstResult?.EntityId).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetOneAgentOnAHostMonitoringConfigAsync()
		{
			var results = await _client.GetAllTopologyHostsAsync().ConfigureAwait(false);
			var firstResult = results.FirstOrDefault();

			var result = await _client.GetOneAgentOnAHostMonitoringConfigAsync(firstResult?.EntityId).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetOneAgentOnAHostTechnologyMonitoringConfigAsync()
		{
			var results = await _client.GetAllTopologyHostsAsync().ConfigureAwait(false);
			var firstResult = results.FirstOrDefault();

			var result = await _client.GetOneAgentOnAHostTechnologyMonitoringConfigAsync(firstResult?.EntityId).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
