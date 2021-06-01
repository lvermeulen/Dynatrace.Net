using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAuditLogAsync()
		{
			var result = await _client.GetAuditLogAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	
		[Fact]
		public async Task GetAuditLogEntryAsync()
		{
			var results = await _client.GetAuditLogAsync().ConfigureAwait(false);
			var firstResult = results.AuditLogs.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetAuditLogEntryAsync(firstResult?.LogId).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
