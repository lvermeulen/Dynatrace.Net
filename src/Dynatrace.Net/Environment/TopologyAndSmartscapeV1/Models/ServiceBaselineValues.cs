using System.Collections.Generic;

namespace Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models
{
	public class ServiceBaselineValues : BaselineValuesBase
	{
		public IEnumerable<EntityBaselineData> ServiceResponseTimeBaselines { get; set; }
	}
}
