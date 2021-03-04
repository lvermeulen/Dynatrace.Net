using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MaskingRuleTypesConverter : JsonEnumConverter<MaskingRuleTypes>
	{
		private static readonly Dictionary<MaskingRuleTypes, string> s_pairs = new Dictionary<MaskingRuleTypes, string>
		{
			[MaskingRuleTypes.Attribute] = "ATTRIBUTE",
			[MaskingRuleTypes.Element] = "ELEMENT"
		};

		protected override Dictionary<MaskingRuleTypes, string> Pairs => s_pairs;

		protected override string EntityString => "masking rule type";
	}
}
