using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetEventsFeedAsync()
		{
			var result = await _client.GetEventsFeedAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	
		[Fact]
		public async Task GetEventAsync()
		{
			var results = await _client.GetEventsFeedAsync().ConfigureAwait(false);
			var firstResult = results.Events.FirstOrDefault();

			var result = await _client.GetEventAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
