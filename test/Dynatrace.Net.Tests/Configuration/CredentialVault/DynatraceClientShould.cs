using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllCredentialsAsync()
		{
			var result = await _client.GetAllCredentialsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetCredentialsAsync()
		{
			var results = await _client.GetAllCredentialsAsync().ConfigureAwait(false);
			var firstResult = results.Credentials.FirstOrDefault();

			var result = await _client.GetCredentialsAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
