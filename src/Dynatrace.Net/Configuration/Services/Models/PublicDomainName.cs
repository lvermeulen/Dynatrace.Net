using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class PublicDomainName
	{
		public IEnumerable<TransformationBase> Transformations { get; set; }
		public string ValueOverride { get; set; }
		public bool? CopyFromHostName { get; set; }
	}
}
