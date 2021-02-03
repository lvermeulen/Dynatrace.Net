using System.Collections.Generic;
using Dynatrace.Net.Environment.Deployment.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class LinuxDistributionFlavorsConverter : JsonEnumConverter<LinuxDistributionFlavors>
	{
		private static readonly Dictionary<LinuxDistributionFlavors, string> s_pairs = new Dictionary<LinuxDistributionFlavors, string>
		{
			[LinuxDistributionFlavors.Default] = "default",
			[LinuxDistributionFlavors.Musl] = "musl"
		};

		protected override Dictionary<LinuxDistributionFlavors, string> Pairs => s_pairs;

		protected override string EntityString => "Linux distribution flavor";
	}
}
