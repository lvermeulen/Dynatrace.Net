using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.ProblemsV2.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetProblemsV2Url()
		{
			return GetBaseUrl()
				.AppendPathSegment("v2/problems");
		}

		public async Task<ProblemsDto> GetProblemsV2Async(IEnumerable<WithOrWithout<ProblemFields>> fields = null, string nextPageKey = null, int? pageSize = null,
			Timeframe from = null, Timeframe to = null, ProblemSelector problemSelector = null, EntitySelector entitySelector = null, IEnumerable<AscendingOrDescending<ProblemSorts>> sort = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(fields)] = string.Join(",", (fields ?? Enumerable.Empty<WithOrWithout<ProblemFields>>())
					.Distinct()
					.Select(x => $"+{x.ToString().ToCamelCase()}")),
				[nameof(nextPageKey)] = nextPageKey,
				[nameof(pageSize)] = pageSize,
				[nameof(from)] = from?.ToString(),
				[nameof(to)] = to?.ToString(),
				[nameof(problemSelector)] = problemSelector?.ToString(),
				[nameof(entitySelector)] = entitySelector?.ToString(),
				[nameof(sort)] = string.Join(",", sort ?? Enumerable.Empty<AscendingOrDescending<ProblemSorts>>())
					.Distinct()
					.Select(x => x.ToString().ToCamelCase())
			};

			var response = await GetProblemsV2Url()
				.SetQueryParams(queryParamValues)
				.GetJsonWithErrorCheckingAsync<ProblemsDto>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<Problem> GetProblemDetailsV2Async(string problemId, IEnumerable<WithOrWithout<ProblemFields>> fields = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(fields)] = string.Join(",", (fields ?? Enumerable.Empty<WithOrWithout<ProblemFields>>())
					.Distinct()
					.Select(x => $"+{x.ToString().ToCamelCase()}"))
			};

			var response = await GetProblemsV2Url()
				.AppendPathSegment(problemId)
				.SetQueryParams(queryParamValues)
				.GetJsonWithErrorCheckingAsync<Problem>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<ProblemCloseResult> PostAndCloseProblemDetailsV2Async(string problemId, ProblemCloseRequestDtoImpl body = null, CancellationToken cancellationToken = default)
		{
			var response = await GetProblemsV2Url()
				.AppendPathSegment("details")
				.AppendPathSegment(problemId)
				.AppendPathSegment("close")
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJsonWithErrorChecking<ProblemCloseResult>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<CommentsList> GetAllProblemDetailsCommentsV2Async(string problemId, string nextPageKey = null, int? pageSize = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(nextPageKey)] = nextPageKey,
				[nameof(pageSize)] = pageSize
			};

			var response = await GetProblemsV2Url()
				.AppendPathSegment(problemId)
				.AppendPathSegment("comments")
				.SetQueryParams(queryParamValues)
				.GetJsonWithErrorCheckingAsync<CommentsList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<CommentDto> GetProblemDetailsCommentV2Async(string problemId, string commentId, CancellationToken cancellationToken = default)
		{
			var response = await GetProblemsV2Url()
				.AppendPathSegment(problemId)
				.AppendPathSegment("comments")
				.AppendPathSegment(commentId)
				.GetJsonWithErrorCheckingAsync<CommentDto>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> AddProblemDetailsCommentV2Async(string problemId, CommentRequestDtoImpl body, CancellationToken cancellationToken = default)
		{
			var response = await GetProblemsV2Url()
				.AppendPathSegment(problemId)
				.AppendPathSegment("comments")
				.PostJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> UpdateProblemDetailsCommentV2Async(string problemId, string commentId, CommentRequestDtoImpl body, CancellationToken cancellationToken = default)
		{
			var response = await GetProblemsV2Url()
				.AppendPathSegment(problemId)
				.AppendPathSegment("comments")
				.AppendPathSegment(commentId)
				.PutJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<bool> DeleteProblemDetailsCommentV2Async(string problemId, string commentId, CancellationToken cancellationToken = default)
		{
			var response = await GetProblemsV2Url()
				.AppendPathSegment(problemId)
				.AppendPathSegment("comments")
				.AppendPathSegment(commentId)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}
