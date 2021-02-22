using System.Collections.Generic;

namespace Dynatrace.Net.Environment.TopologyAndSmartscapeV1.Models
{
	public class ApplicationBaselineValues : BaselineValuesBase
	{
		public IEnumerable<EntityBaselineData> ApplicationDomInteractiveBaselines { get; set; }
		public IEnumerable<EntityBaselineData> ApplicationHtmlDownloadedBaselines { get; set; }
		public IEnumerable<EntityBaselineData> ApplicationLoadEventEndBaselines { get; set; }
		public IEnumerable<EntityBaselineData> ApplicationLoadEventStartBaselines { get; set; }
		public IEnumerable<EntityBaselineData> ApplicationResponseTimeBaselines { get; set; }
		public IEnumerable<EntityBaselineData> ApplicationSpeedIndexBaselines { get; set; }
		public IEnumerable<EntityBaselineData> ApplicationTimeToFirstByteBaselines { get; set; }
		public IEnumerable<EntityBaselineData> ApplicationVisualCompleteBaselines { get; set; }
	}
}
