using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllDetectionRulesOpaqueWebRequestAsync()
		{
			var result = await _client.GetAllDetectionRulesOpaqueWebRequestAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetDetectionRuleOpaqueWebRequestAsync()
		{
			var results = await _client.GetAllDetectionRulesOpaqueWebRequestAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetDetectionRuleOpaqueWebRequestAsync(firstResult.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
