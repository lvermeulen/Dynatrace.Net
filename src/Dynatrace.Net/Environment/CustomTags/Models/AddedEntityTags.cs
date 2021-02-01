using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Environment.CustomTags.Models
{
	public class AddedEntityTags
	{
		public int? MatchedEntitiesCount { get; set; }
		public IEnumerable<MeTag> AppliedTags { get; set; }
	}
}
