using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAnomalyDetectionApplicationAsync()
		{
			var result = await _client.GetAnomalyDetectionApplicationAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
