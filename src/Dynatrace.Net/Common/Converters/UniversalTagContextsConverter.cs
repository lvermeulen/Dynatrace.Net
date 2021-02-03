using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class UniversalTagContextsConverter : JsonEnumConverter<UniversalTagContexts>
	{
		private static readonly Dictionary<UniversalTagContexts, string> s_pairs = new Dictionary<UniversalTagContexts, string>
		{
			[UniversalTagContexts.Aws] = "AWS",
			[UniversalTagContexts.AwsGeneric] = "AWS_GENERIC",
			[UniversalTagContexts.Azure] = "AZURE",
			[UniversalTagContexts.CloudFoundry] = "CLOUD_FOUNDRY",
			[UniversalTagContexts.Contextless] = "CONTEXTLESS",
			[UniversalTagContexts.Environment] = "ENVIRONMENT",
			[UniversalTagContexts.GoogleComputeEngine] = "GOOGLE_COMPUTE_ENGINE",
			[UniversalTagContexts.Kubernetes] = "KUBERNETES"
		};

		protected override Dictionary<UniversalTagContexts, string> Pairs => s_pairs;

		protected override string EntityString => "context";
	}
}
