using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Environment.Events.Models;
using Flurl.Http;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private IFlurlRequest GetEventsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/events");
		}

		public async Task<EventQueryResult> GetEventsFeedAsync(CancellationToken cancellationToken = default)
		{
			var response = await GetEventsUrl()
				.AppendPathSegment("time")
				.GetJsonIfNotEmptyAsync(new EventQueryResult(), cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EventRestEntry> GetEventAsync(string eventId, CancellationToken cancellationToken = default)
		{
			var response = await GetEventsUrl()
				.AppendPathSegment(eventId)
				.GetJsonAsync<EventRestEntry>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EventStoreResult> PushEventAsync(EventCreation body, CancellationToken cancellationToken = default)
		{
			var response = await GetEventsUrl()
				.PostJsonAsync(body, cancellationToken)
				.ReceiveJson<EventStoreResult>()
				.ConfigureAwait(false);

			return response;
		}
	}
}
