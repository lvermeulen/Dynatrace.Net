using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetOneAgentInstanceConfigurationAsync()
		{
			var result = await _client.GetOneAgentInstanceConfigurationAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
