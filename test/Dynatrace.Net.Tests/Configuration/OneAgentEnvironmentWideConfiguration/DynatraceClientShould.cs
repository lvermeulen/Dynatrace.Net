using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetOneAgentEnvironmentWideAutoUpdateConfigAsync()
		{
			var result = await _client.GetOneAgentEnvironmentWideAutoUpdateConfigAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetOneAgentEnvironmentWideTechnologyMonitoringConfigAsync()
		{
			var result = await _client.GetOneAgentEnvironmentWideTechnologyMonitoringConfigAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
