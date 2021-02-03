using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class SyntheticLocationTypesConverter : JsonEnumConverter<SyntheticLocationTypes>
	{
		private static readonly Dictionary<SyntheticLocationTypes, string> s_pairs = new Dictionary<SyntheticLocationTypes, string>
		{
			[SyntheticLocationTypes.Cluster] = "CLUSTER",
			[SyntheticLocationTypes.Public] = "PUBLIC",
			[SyntheticLocationTypes.Private] = "PRIVATE"
		};
		
		protected override Dictionary<SyntheticLocationTypes, string> Pairs => s_pairs;

		protected override string EntityString => "synthetic location type";
	}
}
