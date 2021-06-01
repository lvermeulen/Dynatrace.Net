using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllAzureCredentialsAsync()
		{
			var result = await _client.GetAllAzureCredentialsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetAzureCredentialsAsync()
		{
			var results = await _client.GetAllAzureCredentialsAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetAzureCredentialsAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
