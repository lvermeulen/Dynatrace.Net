using System.Collections.Generic;
using Dynatrace.Net.Environment.SyntheticV1.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class CreatedFromTypesConverter : JsonEnumConverter<CreatedFromTypes>
	{
		private static readonly Dictionary<CreatedFromTypes, string> s_pairs = new Dictionary<CreatedFromTypes, string>
		{
			[CreatedFromTypes.Api] = "API",
			[CreatedFromTypes.Gui] = "GUI"
		};

		protected override Dictionary<CreatedFromTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "created from type";
	}
}
