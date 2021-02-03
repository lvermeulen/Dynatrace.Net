using System.Collections.Generic;
using Dynatrace.Net.Configuration.AwsCredentials.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class PartitionTypesConverter : JsonEnumConverter<PartitionTypes>
	{
		private static readonly Dictionary<PartitionTypes, string> s_pairs = new Dictionary<PartitionTypes, string>
		{
			[PartitionTypes.AwsCn] = "AWS_CN",
			[PartitionTypes.AwsDefault] = "AWS_DEFAULT",
			[PartitionTypes.AwsUsGov] = "AWS_US_GOV"
		};

		protected override Dictionary<PartitionTypes, string> Pairs => s_pairs;

		protected override string EntityString => "partition type";
	}
}
