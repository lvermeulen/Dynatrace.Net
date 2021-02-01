using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Environment.CustomTags.Models
{
	public class CustomEntityTags
	{
		public IEnumerable<MeTag> Tags { get; set; }
		public int? TotalCount { get; set; }
	}
}
