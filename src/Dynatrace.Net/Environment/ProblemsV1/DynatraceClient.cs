using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Environment.ProblemsV1.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private static readonly RelativeTimesConverter s_relativeTimesConverter = new RelativeTimesConverter();
		private static readonly StatusesConverter s_statusesConverter = new StatusesConverter();
		private static readonly ImpactLevelsConverter s_impactLevelsConverter = new ImpactLevelsConverter();
		private static readonly SeverityLevelsConverter s_severityLevelsConverter = new SeverityLevelsConverter();

		private IFlurlRequest GetProblemsV1Url()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/problem");
		}

		public async Task<ProblemStatusResultWrapper> GetProblemsCountV1Async(CancellationToken cancellationToken = default)
		{
			var response = await GetProblemsV1Url()
				.AppendPathSegment("status")
				.GetJsonAsync<ProblemStatusResultWrapper>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<ProblemFeedResultWrapper> GetProblemsFeedV1Async(RelativeTimes? relativeTime = null, int? startTimestamp = null, int? endTimestamp = null, 
			Statuses? status = null, ImpactLevels? impactLevel = null, SeverityLevels? severityLevel = null, IEnumerable<string> tag = null, bool? expandDetails = null,
			CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(relativeTime)] = s_relativeTimesConverter.ConvertToString(relativeTime),
				[nameof(startTimestamp)] = startTimestamp,
				[nameof(endTimestamp)] = endTimestamp,
				[nameof(status)] = s_statusesConverter.ConvertToString(status),
				[nameof(impactLevel)] = s_impactLevelsConverter.ConvertToString(impactLevel),
				[nameof(severityLevel)] = s_severityLevelsConverter.ConvertToString(severityLevel),
				[nameof(tag)] = string.Join("&", (tag ?? Enumerable.Empty<string>()).Select(x => $"tag={x}")),
				[nameof(expandDetails)] = expandDetails
			};

			var response = await GetProblemsV1Url()
				.AppendPathSegment("feed")
				.SetQueryParams(queryParamValues)
				.GetJsonAsync<ProblemFeedResultWrapper>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<ProblemDetailsResultWrapper> GetProblemDetailsV1Async(string problemId, CancellationToken cancellationToken = default)
		{
			var response = await GetProblemsV1Url()
				.AppendPathSegment("details")
				.AppendPathSegment(problemId)
				.GetJsonAsync<ProblemDetailsResultWrapper>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<ProblemCloseResult> CloseProblemDetailsV1Async(string problemId, CancellationToken cancellationToken = default)
		{
			var response = await GetProblemsV1Url()
				.AppendPathSegment("details")
				.AppendPathSegment(problemId)
				.AppendPathSegment("close")
				.GetJsonAsync<ProblemCloseResult>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<ProblemCloseResult> PostAndCloseProblemDetailsV1Async(string problemId, string content, CancellationToken cancellationToken = default)
		{
			var data = new { content };

			var response = await GetProblemsV1Url()
				.AppendPathSegment("details")
				.AppendPathSegment(problemId)
				.AppendPathSegment("close")
				.PostJsonAsync(data, cancellationToken)
				.ReceiveJson<ProblemCloseResult>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<ProblemCommentList> GetAllProblemDetailsCommentsV1Async(string problemId, CancellationToken cancellationToken = default)
		{
			var response = await GetProblemsV1Url()
				.AppendPathSegment("details")
				.AppendPathSegment(problemId)
				.AppendPathSegment("comments")
				.GetJsonAsync<ProblemCommentList>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<ProblemComment> AddProblemDetailsCommentV1Async(string problemId, PushProblemComment body, CancellationToken cancellationToken = default)
		{
			var response = await GetProblemsV1Url()
				.AppendPathSegment("details")
				.AppendPathSegment(problemId)
				.AppendPathSegment("comments")
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<ProblemComment>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<ProblemComment> UpdateProblemDetailsCommentV1Async(string problemId, string commentId, PushProblemComment body, CancellationToken cancellationToken = default)
		{
			var response = await GetProblemsV1Url()
				.AppendPathSegment("details")
				.AppendPathSegment(problemId)
				.AppendPathSegment("comments")
				.AppendPathSegment(commentId)
				.PutJsonAsync(body, cancellationToken)
				.ReceiveJson<ProblemComment>()
				.ConfigureAwait(false);

			return response;
		}

		public async Task<bool> DeleteProblemDetailsCommentV1Async(string problemId, string commentId, CancellationToken cancellationToken = default)
		{
			var response = await GetProblemsV1Url()
				.AppendPathSegment("details")
				.AppendPathSegment(problemId)
				.AppendPathSegment("comments")
				.AppendPathSegment(commentId)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}
	}
}