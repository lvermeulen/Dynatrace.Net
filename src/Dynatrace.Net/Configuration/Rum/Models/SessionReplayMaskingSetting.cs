using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class SessionReplayMaskingSetting
	{
		[JsonConverter(typeof(MaskingPresetTypesConverter))]
		public MaskingPresetTypes? MaskingPreset { get; set; }
		public IEnumerable<MaskingRule> MaskingRules { get; set; }
	}
}
