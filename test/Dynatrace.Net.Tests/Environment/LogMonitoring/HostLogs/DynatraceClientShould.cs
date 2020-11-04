using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetHostLogsAsync()
		{
			const string id = "0";
			var result = await _client.GetHostLogsAsync(id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
