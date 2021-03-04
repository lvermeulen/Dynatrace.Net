using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class PlaceholderProcessingStepTypesConverter : JsonEnumConverter<PlaceholderProcessingStepTypes>
	{
		private static readonly Dictionary<PlaceholderProcessingStepTypes, string> s_pairs = new Dictionary<PlaceholderProcessingStepTypes, string>
		{
			[PlaceholderProcessingStepTypes.ExtractByRegularExpression] = "EXTRACT_BY_REGULAR_EXPRESSION",
			[PlaceholderProcessingStepTypes.Replacement] = "REPLACEMENT",
			[PlaceholderProcessingStepTypes.ReplaceIds] = "REPLACE_IDS",
			[PlaceholderProcessingStepTypes.ReplaceWithPattern] = "REPLACE_WITH_PATTERN",
			[PlaceholderProcessingStepTypes.ReplaceWithRegularExpression] = "REPLACE_WITH_REGULAR_EXPRESSION",
			[PlaceholderProcessingStepTypes.Substring] = "SUBSTRING"
		};

		protected override Dictionary<PlaceholderProcessingStepTypes, string> Pairs => s_pairs;

		protected override string EntityString => "processing step type";
	}
}
