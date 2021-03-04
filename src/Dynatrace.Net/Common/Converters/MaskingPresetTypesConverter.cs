using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MaskingPresetTypesConverter : JsonEnumConverter<MaskingPresetTypes>
	{
		private static readonly Dictionary<MaskingPresetTypes, string> s_pairs = new Dictionary<MaskingPresetTypes, string>
		{
			[MaskingPresetTypes.AllowList] = "ALLOW_LIST",
			[MaskingPresetTypes.BlockList] = "BLOCK_LIST",
			[MaskingPresetTypes.MaskAll] = "MASK_ALL",
			[MaskingPresetTypes.MaskUserInput] = "MASK_USER_INPUT"
		};

		protected override Dictionary<MaskingPresetTypes, string> Pairs => s_pairs;

		protected override string EntityString => "masking preset type";
	}
}
