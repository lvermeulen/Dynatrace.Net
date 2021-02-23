using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllServiceLevelObjectivesAsync()
		{
			var result = await _client.GetAllServiceLevelObjectivesAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	
		[Fact]
		public async Task GetServiceLevelObjectiveAsync()
		{
			var results = await _client.GetAllServiceLevelObjectivesAsync().ConfigureAwait(false);
			var firstResult = results.SLOs.FirstOrDefault();

			var result = await _client.GetServiceLevelObjectiveAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
