using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetDefaultApplicationAsync()
		{
			var result = await _client.GetDefaultApplicationAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
