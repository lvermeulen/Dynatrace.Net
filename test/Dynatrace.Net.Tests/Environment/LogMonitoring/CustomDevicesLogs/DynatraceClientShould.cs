using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetCustomDeviceLogsAsync()
		{
			const string id = "0";
			var result = await _client.GetCustomDeviceLogsAsync(id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
