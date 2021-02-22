using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetRealUserMonitoringBrowserExtensionsAsync()
		{
			var result = await _client.GetRealUserMonitoringBrowserExtensionsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
