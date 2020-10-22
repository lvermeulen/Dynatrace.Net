using System.Collections.Generic;
using Dynatrace.Net.Environment.Events.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class EventCreationEventTypesConverter : JsonEnumConverter<EventCreationEventTypes>
	{
		private static readonly Dictionary<EventCreationEventTypes, string> s_pairs = new Dictionary<EventCreationEventTypes, string>
		{
			[EventCreationEventTypes.AvailabilityEvent] = "AVAILABILITY_EVENT",
			[EventCreationEventTypes.CustomAnnotation] = "CUSTOM_ANNOTATION",
			[EventCreationEventTypes.CustomConfiguration] = "CUSTOM_CONFIGURATION",
			[EventCreationEventTypes.CustomDeployment] = "CUSTOM_DEPLOYMENT",
			[EventCreationEventTypes.CustomInfo] = "CUSTOM_INFO",
			[EventCreationEventTypes.ErrorEvent] = "ERROR_EVENT",
			[EventCreationEventTypes.MarkedForTermination] = "MARKED_FOR_TERMINATION",
			[EventCreationEventTypes.PerformanceEvent] = "PERFORMANCE_EVENT",
			[EventCreationEventTypes.ResourceContention] = "RESOURCE_CONTENTION"
		};

		protected override Dictionary<EventCreationEventTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "event type";
	}
}
