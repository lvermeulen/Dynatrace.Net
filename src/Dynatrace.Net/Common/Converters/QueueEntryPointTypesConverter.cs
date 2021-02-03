using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class QueueEntryPointTypesConverter : JsonEnumConverter<QueueEntryPointTypes>
	{
		private static readonly Dictionary<QueueEntryPointTypes, string> s_pairs = new Dictionary<QueueEntryPointTypes, string>
		{
			[QueueEntryPointTypes.IbmMq] = "IBM_MQ",
			[QueueEntryPointTypes.Jms] = "JMS",
			[QueueEntryPointTypes.Kafka] = "KAFKA",
			[QueueEntryPointTypes.Msmq] = "MSMQ",
			[QueueEntryPointTypes.RabbitMq] = "RABBIT_MQ"
		};

		protected override Dictionary<QueueEntryPointTypes, string> Pairs => s_pairs;

		protected override string EntityString => "queue entrypoint type";
	}
}
