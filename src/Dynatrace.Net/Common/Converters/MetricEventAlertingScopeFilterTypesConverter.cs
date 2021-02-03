using System.Collections.Generic;
using Dynatrace.Net.Configuration.AnomalyDetection.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MetricEventAlertingScopeFilterTypesConverter : JsonEnumConverter<MetricEventAlertingScopeFilterTypes>
	{
		private static readonly Dictionary<MetricEventAlertingScopeFilterTypes, string> s_pairs = new Dictionary<MetricEventAlertingScopeFilterTypes, string>
		{
			[MetricEventAlertingScopeFilterTypes.CustomDeviceGroupName] = "CUSTOM_DEVICE_GROUP_NAME",
			[MetricEventAlertingScopeFilterTypes.EntityId] = "ENTITY_ID",
			[MetricEventAlertingScopeFilterTypes.HostGroupName] = "HOST_GROUP_NAME",
			[MetricEventAlertingScopeFilterTypes.HostName] = "HOST_NAME",
			[MetricEventAlertingScopeFilterTypes.ManagementZone] = "MANAGEMENT_ZONE",
			[MetricEventAlertingScopeFilterTypes.Name] = "NAME",
			[MetricEventAlertingScopeFilterTypes.ProcessGroupId] = "PROCESS_GROUP_ID",
			[MetricEventAlertingScopeFilterTypes.ProcessGroupName] = "PROCESS_GROUP_NAME",
			[MetricEventAlertingScopeFilterTypes.Tag] = "TAG"
		};

		protected override Dictionary<MetricEventAlertingScopeFilterTypes, string> Pairs => s_pairs;

		protected override string EntityString => "metric event alerting scope filter type";
	}
}
