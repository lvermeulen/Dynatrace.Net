using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetMobileAndCustomAppUserActionsAsync()
		{
			var results = await _client.GetAllMobileAndCustomAppsAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetMobileAndCustomAppUserActionsAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetMobileAndCustomAppUserActionAsync()
		{
			var results = await _client.GetAllMobileAndCustomAppsAsync().ConfigureAwait(false);
			var firstResult = results.Values.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var keys = await _client.GetMobileAndCustomAppUserActionsAsync(firstResult?.Id).ConfigureAwait(false);
			var firstKey = keys?.UserActionProperties.FirstOrDefault();
			if (firstKey is null)
			{
				return;
			}

			var result = await _client.GetMobileAndCustomAppUserActionAsync(firstResult?.Id, firstKey?.Key);
			Assert.NotNull(result);
		}
	}
}
