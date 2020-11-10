using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class ApplicationId
	{
		public IEnumerable<TransformationBase> Transformations { get; set; }
		public string ValueOverride { get; set; }
	}
}
