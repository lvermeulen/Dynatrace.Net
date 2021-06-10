using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Extensions;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.Events.Models;
using Dynatrace.Net.Environment.ProblemsV1.Models;
using Flurl.Http;
using Newtonsoft.Json;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net
{
	public partial class DynatraceClient
	{
		private static readonly EventTypesConverter s_eventTypesConverter = new EventTypesConverter();

		private IFlurlRequest GetEventsUrl()
		{
			return GetBaseUrl()
				.AppendPathSegment("v1/events");
		}

		public async Task<EventQueryResult> GetEventsFeedAsync(Timeframe from = null, Timeframe to = null, RelativeTimes? relativeTime = null, EventTypes? eventType = null, string entityId = null,
			string cursor = null, CancellationToken cancellationToken = default)
		{
			var queryParamValues = new Dictionary<string, object>();
			if (from is not null)
			{
				queryParamValues.Add(nameof(from), from.ToString());
			}

			if (to is not null)
			{
				queryParamValues.Add(nameof(to), to.ToString());
			}

			if (relativeTime is not null)
			{
				queryParamValues.Add(nameof(relativeTime), s_relativeTimesConverter.ConvertToString(relativeTime));
			}

			if (eventType is not null)
			{
				queryParamValues.Add(nameof(eventType), s_eventTypesConverter.ConvertToString(eventType));
			}

			if (entityId is not null)
			{
				queryParamValues.Add(nameof(entityId), entityId);
			}

			if (cursor is not null)
			{
				queryParamValues.Add(nameof(cursor), cursor);
			}

			var response = await GetEventsUrl()
				.SetQueryParams(queryParamValues)
				.GetJsonIfNotEmptyAsync(new EventQueryResult(), cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EventRestEntry> GetEventAsync(string eventId, CancellationToken cancellationToken = default)
		{
			var response = await GetEventsUrl()
				.AppendPathSegment(eventId)
				.GetJsonWithErrorCheckingAsync<EventRestEntry>(cancellationToken)
				.ConfigureAwait(false);

			return response;
		}

		public async Task<EventStoreResult> PushEventAsync(EventCreation body, CancellationToken cancellationToken = default)
		{
			var response = await GetEventsUrl()
				.PostJsonAsync(body, cancellationToken)
				.ConfigureAwait(false);

			string content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
			return response.IsSuccessStatusCode
				? JsonConvert.DeserializeObject<EventStoreResult>(content)
				: throw new InvalidOperationException(content);
		}
	}
}
