using System.Collections.Generic;
using Dynatrace.Net.Configuration.OneAgentOnAHost.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class TechnologyTypesConverter : JsonEnumConverter<TechnologyTypes>
	{
		private static readonly Dictionary<TechnologyTypes, string> s_pairs = new Dictionary<TechnologyTypes, string>
		{
			[TechnologyTypes.AixKernelExt] = "AIX_KERNEL_EXT",
			[TechnologyTypes.Apache] = "APACHE",
			[TechnologyTypes.CimV2] = "CIM_V2",
			[TechnologyTypes.Docker] = "DOCKER",
			[TechnologyTypes.DockerWin] = "DOCKER_WIN",
			[TechnologyTypes.DotNet] = "DOT_NET",
			[TechnologyTypes.DotNetCore] = "DOT_NET_CORE",
			[TechnologyTypes.Extensions] = "EXTENSIONS",
			[TechnologyTypes.ExtensionsDsGeneric] = "EXTENSIONS_DS_GENERIC",
			[TechnologyTypes.ExtensionsStatsd] = "EXTENSIONS_STATSD",
			[TechnologyTypes.Garden] = "GARDEN",
			[TechnologyTypes.Go] = "GO",
			[TechnologyTypes.GoStatic] = "GO_STATIC",
			[TechnologyTypes.IbmIntegrationBus] = "IBM_INTEGRATION_BUS",
			[TechnologyTypes.Iis] = "IIS",
			[TechnologyTypes.Java] = "JAVA",
			[TechnologyTypes.LogAnalytics] = "LOG_ANALYTICS",
			[TechnologyTypes.Network] = "NETWORK",
			[TechnologyTypes.Nginx] = "NGINX",
			[TechnologyTypes.NodeJs] = "NODE_JS",
			[TechnologyTypes.Opentracingnative] = "OPENTRACINGNATIVE",
			[TechnologyTypes.Php] = "PHP",
			[TechnologyTypes.Php80Ea] = "PHP_80_EA",
			[TechnologyTypes.PhpCgi] = "PHP_CGI",
			[TechnologyTypes.PhpCli] = "PHP_CLI",
			[TechnologyTypes.PhpWin] = "PHP_WIN",
			[TechnologyTypes.Process] = "PROCESS",
			[TechnologyTypes.Ruby] = "RUBY",
			[TechnologyTypes.Sdk] = "SDK",
			[TechnologyTypes.Varnish] = "VARNISH",
			[TechnologyTypes.ZOs] = "Z_OS"
		};

		protected override Dictionary<TechnologyTypes, string> Pairs => s_pairs;
		protected override string EntityString => "technology type";
	}
}
