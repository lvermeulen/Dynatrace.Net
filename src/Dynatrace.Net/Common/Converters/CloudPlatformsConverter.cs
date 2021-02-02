using System.Collections.Generic;
using Dynatrace.Net.Environment.SyntheticV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class CloudPlatformsConverter : JsonEnumConverter<CloudPlatforms>
	{
		private static readonly Dictionary<CloudPlatforms, string> s_pairs = new Dictionary<CloudPlatforms, string>
		{
			[CloudPlatforms.Aws] = "AWS",
			[CloudPlatforms.Azure] = "AZURE",
			[CloudPlatforms.Alibaba] = "ALIBABA",
			[CloudPlatforms.GoogleCloud] = "GOOGLE_CLOUD",
			[CloudPlatforms.Other] = "OTHER"
		};
		
		protected override Dictionary<CloudPlatforms, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "cloud platform";
	}
}
