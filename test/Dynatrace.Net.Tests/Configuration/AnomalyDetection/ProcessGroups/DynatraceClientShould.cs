using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAnomalyDetectionProcessGroupsConfigurationAsync()
		{
			var results = await _client.GetAllTopologyProcessGroupsAsync().ConfigureAwait(false);
			var firstResult = results.Instance.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetAnomalyDetectionProcessGroupsConfigurationAsync(firstResult.EntityId).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
