using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetProblemsCountV1Async()
		{
			var result = await _client.GetProblemsCountV1Async().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetProblemsFeedV1Async()
		{
			var result = await _client.GetProblemsFeedV1Async().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetProblemDetailsV1Async()
		{
			var results = await _client.GetProblemsFeedV1Async().ConfigureAwait(false);
			var firstResult = results.Result.Problems.FirstOrDefault();

			var result = await _client.GetProblemDetailsV1Async(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetAllProblemDetailsCommentsV1Async()
		{
			var results = await _client.GetProblemsFeedV1Async().ConfigureAwait(false);
			var firstResult = results.Result.Problems.FirstOrDefault();

			var result = await _client.GetAllProblemDetailsCommentsV1Async(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
