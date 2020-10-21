using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetProblemsV2Async()
		{
			var result = await _client.GetProblemsV2Async().ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetProblemDetailsV2Async()
		{
			var results = await _client.GetProblemsV2Async().ConfigureAwait(false);
			var firstResult = results.Problems.FirstOrDefault();

			var result = await _client.GetProblemDetailsV2Async(firstResult?.ProblemId).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetAllProblemDetailsCommentsV2Async()
		{
			var results = await _client.GetProblemsV2Async().ConfigureAwait(false);
			var firstResult = results.Problems.FirstOrDefault();

			var result = await _client.GetAllProblemDetailsCommentsV2Async(firstResult?.ProblemId).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task GetProblemDetailsCommentV2Async()
		{
			var results = await _client.GetProblemsV2Async().ConfigureAwait(false);
			var firstResult = results.Problems.FirstOrDefault();

			var comments = await _client.GetAllProblemDetailsCommentsV2Async(firstResult?.ProblemId).ConfigureAwait(false);
			var firstComment = comments.Comments.FirstOrDefault();

			var result = await _client.GetProblemDetailsCommentV2Async(firstResult?.ProblemId, firstComment?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
