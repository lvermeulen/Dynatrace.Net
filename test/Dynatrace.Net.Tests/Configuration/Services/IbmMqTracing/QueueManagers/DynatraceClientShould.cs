using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllIbmMqTracingQueueManagersAsync()
		{
			var result = await _client.GetAllIbmMqTracingQueueManagersAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetIbmMqTracingQueueManagerAsync()
		{
			var results = await _client.GetAllIbmMqTracingQueueManagersAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetIbmMqTracingQueueManagerAsync(firstResult.Name).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
