using System.Collections.Generic;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class HostOsArchitecturesConverter : JsonEnumConverter<HostOsArchitectures>
	{
		private static readonly Dictionary<HostOsArchitectures, string> s_pairs = new Dictionary<HostOsArchitectures, string>
		{
			[HostOsArchitectures.Arm] = "ARM",
			[HostOsArchitectures.Ia64] = "IA64",
			[HostOsArchitectures.Parisc] = "PARISC",
			[HostOsArchitectures.Ppc] = "PPC",
			[HostOsArchitectures.Ppcle] = "PPCLE",
			[HostOsArchitectures.S390] = "S390",
			[HostOsArchitectures.Sparc] = "SPARC",
			[HostOsArchitectures.X86] = "X86",
			[HostOsArchitectures.Zos] = "ZOS"
		};

		protected override Dictionary<HostOsArchitectures, string> Pairs => s_pairs;

		protected override string EntityString => "host OS architecture";
	}
}
