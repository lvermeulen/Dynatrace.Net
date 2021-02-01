using System.Collections.Generic;
using Dynatrace.Net.Environment.Deployment.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class OsArchitectureTypesConverter : JsonEnumConverter<OsArchitectureTypes>
	{
		private static readonly Dictionary<OsArchitectureTypes, string> s_pairs = new Dictionary<OsArchitectureTypes, string>
		{
			[OsArchitectureTypes.All] = "all",
			[OsArchitectureTypes.Arm] = "arm",
			[OsArchitectureTypes.Ppc] = "ppc",
			[OsArchitectureTypes.Ppcle] = "ppcle",
			[OsArchitectureTypes.S390] = "s390",
			[OsArchitectureTypes.Sparc] = "sparc",
			[OsArchitectureTypes.X86] = "x86"
		};

		protected override Dictionary<OsArchitectureTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "OS architecture type";
	}
}
