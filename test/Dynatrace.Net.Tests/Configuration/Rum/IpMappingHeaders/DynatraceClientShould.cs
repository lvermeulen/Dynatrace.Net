using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetRumIpMappingHeadersConfigurationAsync()
		{
			var result = await _client.GetRumIpMappingHeadersConfigurationAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
