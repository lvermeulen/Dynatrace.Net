using System.Collections.Generic;
using Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class HostPaasTypesConverter : JsonEnumConverter<HostPaasTypes>
	{
		private static readonly Dictionary<HostPaasTypes, string> s_pairs = new Dictionary<HostPaasTypes, string>
		{
			[HostPaasTypes.AwsEcsEc2] = "AWS_ECS_EC2",
			[HostPaasTypes.AwsEcsFargate] = "AWS_ECS_FARGATE",
			[HostPaasTypes.AwsLambda] = "AWS_LAMBDA",
			[HostPaasTypes.AzureFunctions] = "AZURE_FUNCTIONS",
			[HostPaasTypes.AzureWebsites] = "AZURE_WEBSITES",
			[HostPaasTypes.CloudFoundry] = "CLOUD_FOUNDRY",
			[HostPaasTypes.GoogleAppEngine] = "GOOGLE_APP_ENGINE",
			[HostPaasTypes.Heroku] = "HEROKU",
			[HostPaasTypes.Kubernetes] = "KUBERNETES",
			[HostPaasTypes.Openshift] = "OPENSHIFT"
		};

		protected override Dictionary<HostPaasTypes, string> Pairs => s_pairs;

		protected override string EntityString => "host PaaS type";
	}
}
