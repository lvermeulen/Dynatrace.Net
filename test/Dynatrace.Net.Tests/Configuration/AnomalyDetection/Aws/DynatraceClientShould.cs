using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAnomalyDetectionAwsConfigurationAsync()
		{
			var result = await _client.GetAnomalyDetectionAwsConfigurationAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
