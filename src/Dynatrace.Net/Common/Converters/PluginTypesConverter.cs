using System.Collections.Generic;
using Dynatrace.Net.Configuration.Plugins.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class PluginTypesConverter : JsonEnumConverter<PluginTypes>
	{
		private static readonly Dictionary<PluginTypes, string> s_pairs = new Dictionary<PluginTypes, string>
		{
			[PluginTypes.ActiveGate] = "ActiveGate",
			[PluginTypes.Jmx] = "JMX",
			[PluginTypes.OneAgent] = "OneAgent",
			[PluginTypes.Pmi] = "PMI"
		};

		protected override Dictionary<PluginTypes, string> Pairs => s_pairs;

		protected override string EntityString => "plugin type";
	}
}
