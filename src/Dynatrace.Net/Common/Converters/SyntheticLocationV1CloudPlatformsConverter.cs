using System.Collections.Generic;
using Dynatrace.Net.Environment.SyntheticV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class SyntheticLocationV1CloudPlatformsConverter : JsonEnumConverter<SyntheticLocationV1CloudPlatforms>
	{
		private static readonly Dictionary<SyntheticLocationV1CloudPlatforms, string> s_pairs = new Dictionary<SyntheticLocationV1CloudPlatforms, string>
		{
			[SyntheticLocationV1CloudPlatforms.Aws] = "AWS",
			[SyntheticLocationV1CloudPlatforms.Azure] = "AZURE",
			[SyntheticLocationV1CloudPlatforms.Alibaba] = "ALIBABA",
			[SyntheticLocationV1CloudPlatforms.GoogleCloud] = "GOOGLE_CLOUD",
			[SyntheticLocationV1CloudPlatforms.Other] = "OTHER"
		};
		
		protected override Dictionary<SyntheticLocationV1CloudPlatforms, string> Pairs => s_pairs;

		protected override string EntityString => "cloud platform";
	}
}
