using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllMobileSymbolicationMetadatasAsync()
		{
			var result = await _client.GetAllMobileSymbolicationMetadatasAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetMobileSymbolicationStorageInformationAsync()
		{
			var result = await _client.GetMobileSymbolicationStorageInformationAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetMobileSymbolicationMetadataAsync()
		{
			var results = await _client.GetAllMobileSymbolicationMetadatasAsync().ConfigureAwait(false);
			var firstResult = results.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetMobileSymbolicationMetadataAsync(firstResult.AppId.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
