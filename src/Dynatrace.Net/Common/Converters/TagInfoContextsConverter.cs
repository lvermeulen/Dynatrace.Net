using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class TagInfoContextsConverter : JsonEnumConverter<TagInfoContexts>
	{
		private static readonly Dictionary<TagInfoContexts, string> s_pairs = new Dictionary<TagInfoContexts, string>
		{
			[TagInfoContexts.Aws] = "AWS",
			[TagInfoContexts.AwsGeneric] = "AWS_GENERIC",
			[TagInfoContexts.Azure] = "AZURE",
			[TagInfoContexts.CloudFoundry] = "CLOUD_FOUNDRY",
			[TagInfoContexts.Contextless] = "CONTEXTLESS",
			[TagInfoContexts.Environment] = "ENVIRONMENT",
			[TagInfoContexts.GoogleCloud] = "GOOGLE_CLOUD",
			[TagInfoContexts.Kubernetes] = "KUBERNETES"
		};

		protected override Dictionary<TagInfoContexts, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "tag info context";
	}
}
