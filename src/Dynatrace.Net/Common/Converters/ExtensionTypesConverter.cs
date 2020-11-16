using System.Collections.Generic;
using Dynatrace.Net.Configuration.Extensions.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ExtensionTypesConverter : JsonEnumConverter<ExtensionTypes>
	{
		private static readonly Dictionary<ExtensionTypes, string> s_pairs = new Dictionary<ExtensionTypes, string>
		{
			[ExtensionTypes.Activegate] = "ACTIVEGATE",
			[ExtensionTypes.Codemodule] = "CODEMODULE",
			[ExtensionTypes.Jmx] = "JMX",
			[ExtensionTypes.Oneagent] = "ONEAGENT",
			[ExtensionTypes.Pmi] = "PMI",
			[ExtensionTypes.Unknown] = "UNKNOWN"
		};

		protected override Dictionary<ExtensionTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "extension type";
	}
}
