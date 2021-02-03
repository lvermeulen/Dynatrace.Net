using System.Collections.Generic;
using Dynatrace.Net.Environment.Deployment.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class OneAgentDeploymentOsTypesConverter : JsonEnumConverter<OneAgentDeploymentOsTypes>
	{
		private static readonly Dictionary<OneAgentDeploymentOsTypes, string> s_pairs = new Dictionary<OneAgentDeploymentOsTypes, string>
		{
			[OneAgentDeploymentOsTypes.Windows] = "windows",
			[OneAgentDeploymentOsTypes.Unix] = "unix",
			[OneAgentDeploymentOsTypes.Aix] = "aix",
			[OneAgentDeploymentOsTypes.Solaris] = "solaris",
			[OneAgentDeploymentOsTypes.Zos] = "zos"
		};

		protected override Dictionary<OneAgentDeploymentOsTypes, string> Pairs => s_pairs;

		protected override string EntityString => "OneAgent deployment OS type";
	}
}
