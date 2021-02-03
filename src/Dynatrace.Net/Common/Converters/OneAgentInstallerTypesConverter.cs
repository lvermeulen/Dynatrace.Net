using System.Collections.Generic;
using Dynatrace.Net.Environment.Deployment.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class OneAgentInstallerTypesConverter : JsonEnumConverter<OneAgentInstallerTypes>
	{
		private static readonly Dictionary<OneAgentInstallerTypes, string> s_pairs = new Dictionary<OneAgentInstallerTypes, string>
		{
			[OneAgentInstallerTypes.Default] = "default",
			[OneAgentInstallerTypes.DefaultUnattended] = "default-unattended",
			[OneAgentInstallerTypes.Paas] = "paas",
			[OneAgentInstallerTypes.PaasSh] = "paas-sh",
		};

		protected override Dictionary<OneAgentInstallerTypes, string> Pairs => s_pairs;

		protected override string EntityString => "OneAgent installer type";
	}
}
