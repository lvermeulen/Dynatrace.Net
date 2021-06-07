using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetOneAgentOnAHostGroupAutoUpdateConfigAsync()
		{
			var results = await _client.GetAllTopologyHostsAsync().ConfigureAwait(false);
			var firstResult = results.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetOneAgentOnAHostGroupAutoUpdateConfigAsync(firstResult.EntityId).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
