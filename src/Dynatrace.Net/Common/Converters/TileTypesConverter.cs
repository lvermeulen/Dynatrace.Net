using System.Collections.Generic;
using Dynatrace.Net.Configuration.Dashboards.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class TileTypesConverter : JsonEnumConverter<TileTypes>
	{
		private static readonly Dictionary<TileTypes, string> s_pairs = new Dictionary<TileTypes, string>
		{
			[TileTypes.Application] = "APPLICATION",
			[TileTypes.Applications] = "APPLICATIONS",
			[TileTypes.ApplicationMethod] = "APPLICATION_METHOD",
			[TileTypes.ApplicationWorldmap] = "APPLICATION_WORLDMAP",
			[TileTypes.Aws] = "AWS",
			[TileTypes.BounceRate] = "BOUNCE_RATE",
			[TileTypes.CustomApplication] = "CUSTOM_APPLICATION",
			[TileTypes.CustomCharting] = "CUSTOM_CHARTING",
			[TileTypes.Database] = "DATABASE",
			[TileTypes.DatabasesOverview] = "DATABASES_OVERVIEW",
			[TileTypes.DemKeyUserAction] = "DEM_KEY_USER_ACTION",
			[TileTypes.DeviceApplicationMethod] = "DEVICE_APPLICATION_METHOD",
			[TileTypes.Dtaql] = "DTAQL",
			[TileTypes.Host] = "HOST",
			[TileTypes.Hosts] = "HOSTS",
			[TileTypes.LogAnalytics] = "LOG_ANALYTICS",
			[TileTypes.Markdown] = "MARKDOWN",
			[TileTypes.MobileApplication] = "MOBILE_APPLICATION",
			[TileTypes.Openstack] = "OPENSTACK",
			[TileTypes.OpenstackAvZone] = "OPENSTACK_AV_ZONE",
			[TileTypes.OpenstackProject] = "OPENSTACK_PROJECT",
			[TileTypes.ProcessGroupsOne] = "PROCESS_GROUPS_ONE",
			[TileTypes.Resources] = "RESOURCES",
			[TileTypes.Services] = "SERVICES",
			[TileTypes.ServiceVersatile] = "SERVICE_VERSATILE",
			[TileTypes.SessionMetrics] = "SESSION_METRICS",
			[TileTypes.Slo] = "SLO",
			[TileTypes.SyntheticHttpMonitor] = "SYNTHETIC_HTTP_MONITOR",
			[TileTypes.SyntheticSingleExtTest] = "SYNTHETIC_SINGLE_EXT_TEST",
			[TileTypes.SyntheticSingleWebcheck] = "SYNTHETIC_SINGLE_WEBCHECK",
			[TileTypes.SyntheticTests] = "SYNTHETIC_TESTS",
			[TileTypes.ThirdPartyMostActive] = "THIRD_PARTY_MOST_ACTIVE",
			[TileTypes.UemConversionsOverall] = "UEM_CONVERSIONS_OVERALL",
			[TileTypes.UemConversionsPerGoal] = "UEM_CONVERSIONS_PER_GOAL",
			[TileTypes.UemJserrorsOverall] = "UEM_JSERRORS_OVERALL",
			[TileTypes.UemKeyUserActions] = "UEM_KEY_USER_ACTIONS",
			[TileTypes.Users] = "USERS",
			[TileTypes.Virtualization] = "VIRTUALIZATION"
		};

		protected override Dictionary<TileTypes, string> Pairs => s_pairs;

		protected override string EntityString => "tile type";
	}
}
