using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Common.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.Events.Models
{
	public class TagMatchRule
	{
		[JsonConverter(typeof(MeTypesConverter))]
		public IEnumerable<MeTypes> MeTypes { get; set; }
		public IEnumerable<TagInfo> Tags { get; set; }
	}
}
