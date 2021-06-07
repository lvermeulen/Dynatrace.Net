using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllKubernetesCredentialsAsync()
		{
			var result = await _client.GetAllKubernetesCredentialsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetKubernetesCredentialsAsync()
		{
			var results = await _client.GetAllKubernetesCredentialsAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetKubernetesCredentialsAsync(firstResult.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
