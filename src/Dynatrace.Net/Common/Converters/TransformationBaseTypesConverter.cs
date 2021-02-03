using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class TransformationBaseTypesConverter : JsonEnumConverter<TransformationBaseTypes>
	{
		private static readonly Dictionary<TransformationBaseTypes, string> s_pairs = new Dictionary<TransformationBaseTypes, string>
		{
			[TransformationBaseTypes.After] = "AFTER",
			[TransformationBaseTypes.Before] = "BEFORE",
			[TransformationBaseTypes.Between] = "BETWEEN",
			[TransformationBaseTypes.RemoveCreditCards] = "REMOVE_CREDIT_CARDS",
			[TransformationBaseTypes.RemoveIbans] = "REMOVE_IBANS",
			[TransformationBaseTypes.RemoveIps] = "REMOVE_IPS",
			[TransformationBaseTypes.RemoveNumbers] = "REMOVE_NUMBERS",
			[TransformationBaseTypes.ReplaceBetween] = "REPLACE_BETWEEN",
			[TransformationBaseTypes.SplitSelect] = "SPLIT_SELECT",
			[TransformationBaseTypes.TakeSegments] = "TAKE_SEGMENTS"
		};

		protected override Dictionary<TransformationBaseTypes, string> Pairs => s_pairs;

		protected override string EntityString => "transformation base type";
	}
}
