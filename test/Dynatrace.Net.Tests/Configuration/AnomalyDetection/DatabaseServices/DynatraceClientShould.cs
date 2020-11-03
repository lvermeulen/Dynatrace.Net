using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAnomalyDetectionDatabaseServicesConfigurationAsync()
		{
			var result = await _client.GetAnomalyDetectionDatabaseServicesConfigurationAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
