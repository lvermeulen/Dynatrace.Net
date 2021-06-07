using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllCloudFoundryCredentialsAsync()
		{
			var result = await _client.GetAllCloudFoundryCredentialsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetCloudFoundryCredentialsAsync()
		{
			var results = await _client.GetAllCloudFoundryCredentialsAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetCloudFoundryCredentialsAsync(firstResult.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
