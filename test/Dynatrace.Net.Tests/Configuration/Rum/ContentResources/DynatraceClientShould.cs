using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetRumContentProvidersConfigurationAsync()
		{
			var result = await _client.GetRumContentProvidersConfigurationAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
