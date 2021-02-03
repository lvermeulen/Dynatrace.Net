using System.Collections.Generic;
using Dynatrace.Net.Configuration.ManagementZones.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class PropagationTypesConverter : JsonEnumConverter<PropagationTypes>
	{
		private static readonly Dictionary<PropagationTypes, string> s_pairs = new Dictionary<PropagationTypes, string>
		{
			[PropagationTypes.AzureToPg] = "AZURE_TO_PG",
			[PropagationTypes.AzureToService] = "AZURE_TO_SERVICE",
			[PropagationTypes.CustomDeviceGroupToCustomDevice] = "CUSTOM_DEVICE_GROUP_TO_CUSTOM_DEVICE",
			[PropagationTypes.HostToProcessGroupInstance] = "HOST_TO_PROCESS_GROUP_INSTANCE",
			[PropagationTypes.ProcessGroupToHost] = "PROCESS_GROUP_TO_HOST",
			[PropagationTypes.ProcessGroupToService] = "PROCESS_GROUP_TO_SERVICE",
			[PropagationTypes.ServiceToHostLike] = "SERVICE_TO_HOST_LIKE",
			[PropagationTypes.ServiceToProcessGroupLike] = "SERVICE_TO_PROCESS_GROUP_LIKE"
		};

		protected override Dictionary<PropagationTypes, string> Pairs => s_pairs;

		protected override string EntityString => "propagation type";
	}
}
