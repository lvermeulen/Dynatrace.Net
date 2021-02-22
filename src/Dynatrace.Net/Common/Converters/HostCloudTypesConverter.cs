using System.Collections.Generic;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class HostCloudTypesConverter : JsonEnumConverter<HostCloudTypes>
	{
		private static readonly Dictionary<HostCloudTypes, string> s_pairs = new Dictionary<HostCloudTypes, string>
		{
			[HostCloudTypes.Azure] = "AZURE",
			[HostCloudTypes.Ec2] = "EC2",
			[HostCloudTypes.GoogleCloudPlatform] = "GOOGLE_CLOUD_PLATFORM",
			[HostCloudTypes.Openstack] = "OPENSTACK",
			[HostCloudTypes.Oracle] = "ORACLE",
			[HostCloudTypes.Unrecognized] = "UNRECOGNIZED"
		};

		protected override Dictionary<HostCloudTypes, string> Pairs => s_pairs;

		protected override string EntityString => "host cloud type";
	}
}
