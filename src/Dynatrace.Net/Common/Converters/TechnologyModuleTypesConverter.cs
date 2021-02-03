using System.Collections.Generic;
using Dynatrace.Net.Environment.OneAgentOnAHost.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class TechnologyModuleTypesConverter : JsonEnumConverter<TechnologyModuleTypes>
	{
		private static readonly Dictionary<TechnologyModuleTypes, string> s_pairs = new Dictionary<TechnologyModuleTypes, string>
		{
			[TechnologyModuleTypes.Apache] = "APACHE",
			[TechnologyModuleTypes.DotNet] = "DOT_NET",
			[TechnologyModuleTypes.Dumpproc] = "DUMPPROC",
			[TechnologyModuleTypes.Go] = "GO",
			[TechnologyModuleTypes.IbmIntegrationBus] = "IBM_INTEGRATION_BUS",
			[TechnologyModuleTypes.Iis] = "IIS",
			[TechnologyModuleTypes.Java] = "JAVA",
			[TechnologyModuleTypes.LogAnalytics] = "LOG_ANALYTICS",
			[TechnologyModuleTypes.Network] = "NETWORK",
			[TechnologyModuleTypes.Nginx] = "NGINX",
			[TechnologyModuleTypes.NodeJs] = "NODE_JS",
			[TechnologyModuleTypes.Opentracingnative] = "OPENTRACINGNATIVE",
			[TechnologyModuleTypes.Php] = "PHP",
			[TechnologyModuleTypes.Process] = "PROCESS",
			[TechnologyModuleTypes.Python] = "PYTHON",
			[TechnologyModuleTypes.Ruby] = "RUBY",
			[TechnologyModuleTypes.Sdk] = "SDK",
			[TechnologyModuleTypes.Updater] = "UPDATER",
			[TechnologyModuleTypes.Varnish] = "VARNISH",
			[TechnologyModuleTypes.ZOs] = "Z_OS"
		};

		protected override Dictionary<TechnologyModuleTypes, string> Pairs => s_pairs;

		protected override string EntityString => "technology module";
	}
}
