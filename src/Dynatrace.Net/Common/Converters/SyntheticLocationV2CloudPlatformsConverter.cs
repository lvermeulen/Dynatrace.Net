using System.Collections.Generic;
using Dynatrace.Net.Environment.SyntheticV2.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class SyntheticLocationV2CloudPlatformsConverter : JsonEnumConverter<SyntheticLocationV2CloudPlatforms>
	{
		private static readonly Dictionary<SyntheticLocationV2CloudPlatforms, string> s_pairs = new Dictionary<SyntheticLocationV2CloudPlatforms, string>
		{
			[SyntheticLocationV2CloudPlatforms.Alibaba] = "ALIBABA",
			[SyntheticLocationV2CloudPlatforms.AmazonEc2] = "AMAZON_EC2",
			[SyntheticLocationV2CloudPlatforms.Azure] = "AZURE",
			[SyntheticLocationV2CloudPlatforms.DynatraceCloud] = "DYNATRACE_CLOUD",
			[SyntheticLocationV2CloudPlatforms.GoogleCloud] = "GOOGLE_CLOUD",
			[SyntheticLocationV2CloudPlatforms.Interoute] = "INTEROUTE",
			[SyntheticLocationV2CloudPlatforms.Other] = "OTHER",
			[SyntheticLocationV2CloudPlatforms.Physical] = "PHYSICAL",
			[SyntheticLocationV2CloudPlatforms.Undefined] = "UNDEFINED"
		};
		
		protected override Dictionary<SyntheticLocationV2CloudPlatforms, string> Pairs => s_pairs;

		protected override string EntityString => "cloud platform";
	}
}
