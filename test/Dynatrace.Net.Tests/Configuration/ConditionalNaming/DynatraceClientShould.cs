using System.Linq;
using System.Threading.Tasks;
using Dynatrace.Net.Configuration.ConditionalNaming.Models;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllConditionalNamingRulesAsync()
		{
			var result = await _client.GetAllConditionalNamingRulesAsync(ConditionalNamingTypes.Host).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetConditionalNamingRuleAsync()
		{
			var results = await _client.GetAllConditionalNamingRulesAsync(ConditionalNamingTypes.Host).ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetConditionalNamingRuleAsync(ConditionalNamingTypes.Host, firstResult.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
