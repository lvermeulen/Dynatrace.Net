using System.Collections.Generic;
using Dynatrace.Net.Environment.Deployment.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class WindowsUnixDeploymentOsTypesConverter : JsonEnumConverter<WindowsUnixDeploymentOsTypes>
	{
		private static readonly Dictionary<WindowsUnixDeploymentOsTypes, string> s_pairs = new Dictionary<WindowsUnixDeploymentOsTypes, string>
		{
			[WindowsUnixDeploymentOsTypes.Windows] = "windows",
			[WindowsUnixDeploymentOsTypes.Unix] = "unix"
		};

		protected override Dictionary<WindowsUnixDeploymentOsTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "deployment OS type";
	}
}
