using System.Linq;
using System.Threading.Tasks;
using Dynatrace.Net.Configuration.Services.Models;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllCustomServiceRulesAsync()
		{
			var result = await _client.GetAllCustomServiceRulesAsync(CustomServiceTechnologies.DotNet).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetCustomServiceRuleAsync()
		{
			var results = await _client.GetAllCustomServiceRulesAsync(CustomServiceTechnologies.DotNet).ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetCustomServiceRuleAsync(CustomServiceTechnologies.DotNet, firstResult.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
