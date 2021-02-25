using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllRumApplicationDetectionRulesAsync()
		{
			var result = await _client.GetAllRumApplicationDetectionRulesAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetRumApplicationDetectionRuleAsync()
		{
			var results = await _client.GetAllRumApplicationDetectionRulesAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();

			var result = await _client.GetRumApplicationDetectionRuleAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetRumApplicationDetectionHostDetectionHeadersAsync()
		{
			var result = await _client.GetRumApplicationDetectionHostDetectionHeadersAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
