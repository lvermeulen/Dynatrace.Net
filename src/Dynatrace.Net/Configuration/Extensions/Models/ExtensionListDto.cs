using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Extensions.Models
{
	public class ExtensionListDto
	{
		public IEnumerable<ExtensionDto> Extensions { get; set; }
		public int? TotalResults { get; set; }
		public string NextPageKey { get; set; }
	}
}
