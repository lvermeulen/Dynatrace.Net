using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllRequestNamingRulesAsync()
		{
			var result = await _client.GetAllRequestNamingRulesAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetRequestNamingRuleAsync()
		{
			var results = await _client.GetAllRequestNamingRulesAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetRequestNamingRuleAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
