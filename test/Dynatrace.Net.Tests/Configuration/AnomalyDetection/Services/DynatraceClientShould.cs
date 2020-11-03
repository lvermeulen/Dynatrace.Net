using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAnomalyDetectionServicesConfigurationAsync()
		{
			var result = await _client.GetAnomalyDetectionServicesConfigurationAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
