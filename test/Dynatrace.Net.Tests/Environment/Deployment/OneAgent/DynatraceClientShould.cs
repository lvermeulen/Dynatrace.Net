using System.Threading.Tasks;
using Dynatrace.Net.Environment.Deployment.Models;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task ListOneAgentAvailableVersionsAsync()
		{
			var result = await _client.ListOneAgentAvailableVersionsAsync(OneAgentDeploymentOsTypes.Windows, OneAgentInstallerTypes.Default).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
