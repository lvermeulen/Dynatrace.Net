using System.Collections.Generic;
using Dynatrace.Net.Configuration.ConditionalNaming.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ConditionalNamingTypesConverter : JsonEnumConverter<ConditionalNamingTypes>
	{
		private static readonly Dictionary<ConditionalNamingTypes, string> s_pairs = new Dictionary<ConditionalNamingTypes, string>
		{
			[ConditionalNamingTypes.ProcessGroup] = "processGroup",
			[ConditionalNamingTypes.Host] = "host",
			[ConditionalNamingTypes.Service] = "service"
		};

		protected override Dictionary<ConditionalNamingTypes, string> Pairs => s_pairs;

		protected override string EntityString => "conditional naming type";
	}
}
