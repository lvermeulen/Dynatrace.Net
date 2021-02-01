using System.Collections.Generic;
using Dynatrace.Net.Environment.ActiveGates.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ActiveGatesOsTypesConverter : JsonEnumConverter<ActiveGatesOsTypes>
	{
		private static readonly Dictionary<ActiveGatesOsTypes, string> s_pairs = new Dictionary<ActiveGatesOsTypes, string>
		{
			[ActiveGatesOsTypes.Linux] = "LINUX",
			[ActiveGatesOsTypes.Windows] = "WINDOWS"
		};

		protected override Dictionary<ActiveGatesOsTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "OS type";
	}
}
