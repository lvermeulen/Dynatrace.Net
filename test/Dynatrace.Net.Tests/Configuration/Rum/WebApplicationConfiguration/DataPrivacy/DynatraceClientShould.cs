using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllWebApplicationsDataPrivacyAsync()
		{
			var result = await _client.GetAllWebApplicationsDataPrivacyAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetWebApplicationDataPrivacyAsync()
		{
			var results = await _client.GetAllWebApplicationsDataPrivacyAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetWebApplicationDataPrivacyAsync(firstResult?.Identifier).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetDefaultApplicationDataPrivacyAsync()
		{
			var result = await _client.GetDefaultApplicationDataPrivacyAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
