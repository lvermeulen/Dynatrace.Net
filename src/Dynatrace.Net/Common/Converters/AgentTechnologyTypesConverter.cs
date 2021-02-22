using System.Collections.Generic;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class AgentTechnologyTypesConverter : JsonEnumConverter<AgentTechnologyTypes>
	{
		private static readonly Dictionary<AgentTechnologyTypes, string> s_pairs = new Dictionary<AgentTechnologyTypes, string>
		{
			[AgentTechnologyTypes.Apache] = "APACHE",
			[AgentTechnologyTypes.Dotnet] = "DOTNET",
			[AgentTechnologyTypes.Dumpproc] = "DUMPPROC",
			[AgentTechnologyTypes.Go] = "GO",
			[AgentTechnologyTypes.Iis] = "IIS",
			[AgentTechnologyTypes.Java] = "JAVA",
			[AgentTechnologyTypes.LogAnalytics] = "LOG_ANALYTICS",
			[AgentTechnologyTypes.NotApplicable] = "N/A",
			[AgentTechnologyTypes.Net] = "NET",
			[AgentTechnologyTypes.Nginx] = "NGINX",
			[AgentTechnologyTypes.Nodejs] = "NODEJS",
			[AgentTechnologyTypes.Opentracingnative] = "OPENTRACINGNATIVE",
			[AgentTechnologyTypes.Os] = "OS",
			[AgentTechnologyTypes.Php] = "PHP",
			[AgentTechnologyTypes.Plugin] = "PLUGIN",
			[AgentTechnologyTypes.Process] = "PROCESS",
			[AgentTechnologyTypes.Python] = "PYTHON",
			[AgentTechnologyTypes.RemotePlugin] = "REMOTE_PLUGIN",
			[AgentTechnologyTypes.Ruby] = "RUBY",
			[AgentTechnologyTypes.Sdk] = "SDK",
			[AgentTechnologyTypes.Updater] = "UPDATER",
			[AgentTechnologyTypes.Varnish] = "VARNISH",
			[AgentTechnologyTypes.Wsmb] = "WSMB",
			[AgentTechnologyTypes.Z] = "Z"
		};

		protected override Dictionary<AgentTechnologyTypes, string> Pairs => s_pairs;

		protected override string EntityString => "agent technology type";
	}
}
