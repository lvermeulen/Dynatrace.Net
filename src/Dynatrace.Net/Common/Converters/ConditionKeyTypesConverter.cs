using System.Collections.Generic;
using Dynatrace.Net.Configuration.ManagementZones.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ConditionKeyTypesConverter : JsonEnumConverter<ConditionKeyTypes>
	{
		private static readonly Dictionary<ConditionKeyTypes, string> s_pairs = new Dictionary<ConditionKeyTypes, string>
		{
			[ConditionKeyTypes.HostCustomMetadataKey] = "HOST_CUSTOM_METADATA_KEY",
			[ConditionKeyTypes.ProcessCustomMetadataKey] = "PROCESS_CUSTOM_METADATA_KEY",
			[ConditionKeyTypes.ProcessPredefinedMetadataKey] = "PROCESS_PREDEFINED_METADATA_KEY",
			[ConditionKeyTypes.String] = "STRING"
		};

		protected override Dictionary<ConditionKeyTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "condition key type";
	}
}
