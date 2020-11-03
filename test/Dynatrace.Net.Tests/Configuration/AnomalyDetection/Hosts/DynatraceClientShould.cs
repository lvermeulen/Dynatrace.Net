using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAnomalyDetectionHostsConfigurationAsync()
		{
			var result = await _client.GetAnomalyDetectionHostsConfigurationAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
