using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllAwsCredentialsAsync()
		{
			var result = await _client.GetAllAwsCredentialsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetAwsCredentialsAsync()
		{
			var results = await _client.GetAllAwsCredentialsAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();

			var result = await _client.GetAwsCredentialsAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
