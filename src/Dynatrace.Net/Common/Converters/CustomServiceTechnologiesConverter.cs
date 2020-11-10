using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class CustomServiceTechnologiesConverter : JsonEnumConverter<CustomServiceTechnologies>
	{
		private static readonly Dictionary<CustomServiceTechnologies, string> s_pairs = new Dictionary<CustomServiceTechnologies, string>
		{
			[CustomServiceTechnologies.DotNet] = "dotNet",
			[CustomServiceTechnologies.Go] = "go",
			[CustomServiceTechnologies.Java] = "java",
			[CustomServiceTechnologies.NodeJs] = "nodeJS",
			[CustomServiceTechnologies.Php] = "php"
		};

		protected override Dictionary<CustomServiceTechnologies, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "service technology";
	}
}
