using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class ContextRoot
	{
		public IEnumerable<ContextRootTransformation> Transformations { get; set; }
		public int? SegmentsToCopyFromUrlPath { get; set; }
	}
}
