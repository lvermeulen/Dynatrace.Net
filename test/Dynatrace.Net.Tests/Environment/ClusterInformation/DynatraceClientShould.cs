using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetClusterTimeAsync()
		{
			string result = await _client.GetClusterTimeAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	
		[Fact]
		public async Task GetClusterVersionAsync()
		{
			var result = await _client.GetClusterVersionAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
