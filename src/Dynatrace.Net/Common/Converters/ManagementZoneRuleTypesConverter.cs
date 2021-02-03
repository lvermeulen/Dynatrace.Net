using System.Collections.Generic;
using Dynatrace.Net.Configuration.ManagementZones.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ManagementZoneRuleTypesConverter : JsonEnumConverter<ManagementZoneRuleTypes>
	{
		private static readonly Dictionary<ManagementZoneRuleTypes, string> s_pairs = new Dictionary<ManagementZoneRuleTypes, string>
		{
			[ManagementZoneRuleTypes.AppmonServer] = "APPMON_SERVER",
			[ManagementZoneRuleTypes.AppmonSystemProfile] = "APPMON_SYSTEM_PROFILE",
			[ManagementZoneRuleTypes.AwsAccount] = "AWS_ACCOUNT",
			[ManagementZoneRuleTypes.AwsApplicationLoadBalancer] = "AWS_APPLICATION_LOAD_BALANCER",
			[ManagementZoneRuleTypes.AwsAutoScalingGroup] = "AWS_AUTO_SCALING_GROUP",
			[ManagementZoneRuleTypes.AwsClassicLoadBalancer] = "AWS_CLASSIC_LOAD_BALANCER",
			[ManagementZoneRuleTypes.AwsNetworkLoadBalancer] = "AWS_NETWORK_LOAD_BALANCER",
			[ManagementZoneRuleTypes.AwsRelationalDatabaseService] = "AWS_RELATIONAL_DATABASE_SERVICE",
			[ManagementZoneRuleTypes.Azure] = "AZURE",
			[ManagementZoneRuleTypes.BrowserMonitor] = "BROWSER_MONITOR",
			[ManagementZoneRuleTypes.CloudApplication] = "CLOUD_APPLICATION",
			[ManagementZoneRuleTypes.CloudApplicationNamespace] = "CLOUD_APPLICATION_NAMESPACE",
			[ManagementZoneRuleTypes.CloudFoundryFoundation] = "CLOUD_FOUNDRY_FOUNDATION",
			[ManagementZoneRuleTypes.CustomApplication] = "CUSTOM_APPLICATION",
			[ManagementZoneRuleTypes.CustomDevice] = "CUSTOM_DEVICE",
			[ManagementZoneRuleTypes.CustomDeviceGroup] = "CUSTOM_DEVICE_GROUP",
			[ManagementZoneRuleTypes.DataCenterService] = "DATA_CENTER_SERVICE",
			[ManagementZoneRuleTypes.EnterpriseApplication] = "ENTERPRISE_APPLICATION",
			[ManagementZoneRuleTypes.EsxiHost] = "ESXI_HOST",
			[ManagementZoneRuleTypes.ExternalMonitor] = "EXTERNAL_MONITOR",
			[ManagementZoneRuleTypes.Host] = "HOST",
			[ManagementZoneRuleTypes.HostGroup] = "HOST_GROUP",
			[ManagementZoneRuleTypes.HttpMonitor] = "HTTP_MONITOR",
			[ManagementZoneRuleTypes.KubernetesCluster] = "KUBERNETES_CLUSTER",
			[ManagementZoneRuleTypes.MobileApplication] = "MOBILE_APPLICATION",
			[ManagementZoneRuleTypes.OpenstackAccount] = "OPENSTACK_ACCOUNT",
			[ManagementZoneRuleTypes.ProcessGroup] = "PROCESS_GROUP",
			[ManagementZoneRuleTypes.Service] = "SERVICE",
			[ManagementZoneRuleTypes.WebApplication] = "WEB_APPLICATION"
		};

		protected override Dictionary<ManagementZoneRuleTypes, string> Pairs => s_pairs;

		protected override string EntityString => "rule type";
	}
}
