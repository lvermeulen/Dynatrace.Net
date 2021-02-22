using System.Collections.Generic;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class HostUserLevelsConverter : JsonEnumConverter<HostUserLevels>
	{
		private static readonly Dictionary<HostUserLevels, string> s_pairs = new Dictionary<HostUserLevels, string>
		{
			[HostUserLevels.NonSuperuser] = "NON_SUPERUSER",
			[HostUserLevels.NonSuperuserStrict] = "NON_SUPERUSER_STRICT",
			[HostUserLevels.Superuser] = "SUPERUSER"
		};

		protected override Dictionary<HostUserLevels, string> Pairs => s_pairs;

		protected override string EntityString => "host user level";
	}
}
