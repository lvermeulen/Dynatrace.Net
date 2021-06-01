using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllIbmMqTracingQueuesAsync()
		{
			var result = await _client.GetAllIbmMqTracingQueuesAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetIbmMqTracingQueueAsync()
		{
			var results = await _client.GetAllIbmMqTracingQueuesAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetIbmMqTracingQueueAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
