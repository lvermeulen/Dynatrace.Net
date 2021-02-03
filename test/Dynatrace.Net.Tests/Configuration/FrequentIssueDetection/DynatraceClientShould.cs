using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetFrequentIssueDetectionConfigurationAsync()
		{
			var result = await _client.GetFrequentIssueDetectionConfigurationAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
