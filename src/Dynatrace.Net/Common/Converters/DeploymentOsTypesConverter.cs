using System.Collections.Generic;
using Dynatrace.Net.Environment.Deployment.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class DeploymentOsTypesConverter : JsonEnumConverter<DeploymentOsTypes>
	{
		private static readonly Dictionary<DeploymentOsTypes, string> s_pairs = new Dictionary<DeploymentOsTypes, string>
		{
			[DeploymentOsTypes.Windows] = "windows",
			[DeploymentOsTypes.Unix] = "unix"
		};

		protected override Dictionary<DeploymentOsTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "deployment OS type";
	}
}
