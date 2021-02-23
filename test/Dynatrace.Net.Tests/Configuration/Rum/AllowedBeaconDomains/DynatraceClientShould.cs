using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetRumAllowedBeaconDomainsConfigurationAsync()
		{
			var result = await _client.GetRumAllowedBeaconDomainsConfigurationAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
