using System.Collections.Generic;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ApplicationMatchTargetsConverter : JsonEnumConverter<ApplicationMatchTargets>
	{
		private static readonly Dictionary<ApplicationMatchTargets, string> s_pairs = new Dictionary<ApplicationMatchTargets, string>
		{
			[ApplicationMatchTargets.Domain] = "DOMAIN",
			[ApplicationMatchTargets.Url] = "URL",
		};

		protected override Dictionary<ApplicationMatchTargets, string> Pairs => s_pairs;

		protected override string EntityString => "application match target";
	}
}
