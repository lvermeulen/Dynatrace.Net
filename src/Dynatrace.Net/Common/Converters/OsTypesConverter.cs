using System.Collections.Generic;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class OsTypesConverter : JsonEnumConverter<OsTypes>
	{
		private static readonly Dictionary<OsTypes, string> s_pairs = new Dictionary<OsTypes, string>
		{
			[OsTypes.Aix] = "AIX",
			[OsTypes.Darwin] = "DARWIN",
			[OsTypes.Hpux] = "HPUX",
			[OsTypes.Linux] = "LINUX",
			[OsTypes.Solaris] = "SOLARIS",
			[OsTypes.Windows] = "WINDOWS",
			[OsTypes.Zos] = "ZOS"
		};

		protected override Dictionary<OsTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "OS type";
	}
}
