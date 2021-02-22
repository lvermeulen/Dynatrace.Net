using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetDataPrivacyConfigurationAsync()
		{
			var result = await _client.GetDataPrivacyConfigurationAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
