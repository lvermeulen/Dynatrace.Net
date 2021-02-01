using System.Threading.Tasks;
using Dynatrace.Net.Environment.Deployment.Models;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task ListBoshReleaseAvailableVersionsAsync()
		{
			var result = await _client.ListBoshReleaseAvailableVersionsAsync(WindowsUnixDeploymentOsTypes.Windows).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
