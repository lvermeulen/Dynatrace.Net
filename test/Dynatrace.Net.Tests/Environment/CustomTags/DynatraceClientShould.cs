using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetTagsAsync()
		{
			var result = await _client.GetTagsAsync(new EntitySelector { HealthState = HealthStates.Unhealthy }, Timeframe.FromUtcMilliseconds(10 * 1000), Timeframe.FromUtcMilliseconds(1000)).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
