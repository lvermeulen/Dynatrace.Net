using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllReportsAsync()
		{
			var result = await _client.GetAllReportsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetReportAsync()
		{
			var results = await _client.GetAllReportsAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();

			var result = await _client.GetReportAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
