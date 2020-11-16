using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetUserSessionsAsTableAsync()
		{
			var result = await _client.GetUserSessionsAsTableAsync("SELECT country, city, avg(duration), max(duration) FROM usersession GROUP BY country, city").ConfigureAwait(false);
			Assert.NotNull(result);
		}
	
		[Fact]
		public async Task GetUserSessionsAsTreeAsync()
		{
			var result = await _client.GetUserSessionsAsTreeAsync("SELECT country, city, avg(duration), max(duration) FROM usersession GROUP BY country, city").ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
