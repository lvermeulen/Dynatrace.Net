using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAwsPrivateLinkConfigAsync()
		{
			var result = await _client.GetAwsPrivateLinkConfigAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetAwsPrivateLinkWhiteListedAccountsAsync()
		{
			var result = await _client.GetAwsPrivateLinkWhiteListedAccountsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
