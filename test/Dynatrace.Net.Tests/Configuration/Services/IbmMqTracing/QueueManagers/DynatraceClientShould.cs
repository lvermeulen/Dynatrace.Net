using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAll()
		{
			var result = await _client.GetAllIbmMqTracingQueueManagersAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task Get()
		{
			var results = await _client.GetAllIbmMqTracingQueueManagersAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();

			var result = await _client.GetIbmMqTracingQueueManagerAsync(firstResult?.Name).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
