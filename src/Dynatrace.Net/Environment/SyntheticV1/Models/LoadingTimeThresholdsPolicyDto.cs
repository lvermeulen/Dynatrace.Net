using System.Collections.Generic;

namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class LoadingTimeThresholdsPolicyDto
	{
		public bool? Enabled { get; set;}
		public IEnumerable<LoadingTimeThreshold> Thresholds { get; set; }
	}
}
