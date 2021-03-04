using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class RuleTypesConverter : JsonEnumConverter<RuleTypes>
	{
		private static readonly Dictionary<RuleTypes, string> s_pairs = new Dictionary<RuleTypes, string>
		{
			[RuleTypes.AfterSpecificHtml] = "AFTER_SPECIFIC_HTML",
			[RuleTypes.AutomaticInjection] = "AUTOMATIC_INJECTION",
			[RuleTypes.BeforeSpecificHtml] = "BEFORE_SPECIFIC_HTML",
			[RuleTypes.DoNotInject] = "DO_NOT_INJECT"
		};

		protected override Dictionary<RuleTypes, string> Pairs => s_pairs;

		protected override string EntityString => "rule type";
	}
}
