using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetAllRemoteEnvironmentsAsync()
		{
			var result = await _client.GetAllRemoteEnvironmentsAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
