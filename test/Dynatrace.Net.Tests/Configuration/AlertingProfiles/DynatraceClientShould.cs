using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAlertingProfilesAsync()
		{
			var result = await _client.GetAlertingProfilesAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetAlertingProfileAsync()
		{
			var results = await _client.GetAlertingProfilesAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetAlertingProfileAsync(firstResult.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
