using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Configuration.Reports.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private static readonly ReportTypesConverter s_reportTypesConverter = new ReportTypesConverter();

		private IFlurlRequest GetReportsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("config/v1/reports");
		}

		public async Task<ReportStubList> GetAllReportsAsync(ReportTypes? type = null, string sourceId = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>
			{
				[nameof(type)] = s_reportTypesConverter.ConvertToString(type),
				[nameof(sourceId)] = sourceId
			};

			var result = await GetReportsUrl()
				.SetQueryParams(queryParamValues)
				.GetJsonAsync<ReportStubList>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<DashboardReport> GetReportAsync(string id, CancellationToken cancellationToken = default)
		{
			var result = await GetReportsUrl()
				.AppendPathSegment(id)
				.GetJsonAsync<DashboardReport>(cancellationToken)
				.ConfigureAwait(false);

			return result;
		}

		public async Task<EntityShortRepresentation> CreateReportAsync(DashboardReport body, CancellationToken cancellationToken = default)
		{
			var result = await GetReportsUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return result;
		}

		public async Task<EntityShortRepresentation> UpdateReportAsync(string id, DashboardReport body, CancellationToken cancellationToken = default)
		{
			var result = await GetReportsUrl()
				.AppendPathSegment(id)
				.PutJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return result;
		}

		public async Task<bool> DeleteReportAsync(string id, CancellationToken cancellationToken = default)
		{
			var response = await GetReportsUrl()
				.AppendPathSegment(id)
				.DeleteAsync(cancellationToken)
				.ConfigureAwait(false);

			return response.IsSuccessStatusCode;
		}

		public async Task<EntityShortRepresentation> AddReportSubscriptionAsync(string id, ReportSubscriptions body, CancellationToken cancellationToken = default)
		{
			var result = await GetReportsUrl()
				.AppendPathSegment(id)
				.AppendPathSegment("subscribe")
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return result;
		}

		public async Task<EntityShortRepresentation> RemoveReportSubscriptionAsync(string id, ReportSubscriptions body, CancellationToken cancellationToken = default)
		{
			var result = await GetReportsUrl()
				.AppendPathSegment(id)
				.AppendPathSegment("unsubscribe")
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<EntityShortRepresentation>()
				.ConfigureAwait(false);

			return result;
		}
	}
}
