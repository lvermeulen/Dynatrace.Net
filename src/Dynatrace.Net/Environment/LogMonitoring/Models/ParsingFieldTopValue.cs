using System.Collections.Generic;

namespace Dynatrace.Net.Environment.LogMonitoring.Models
{
	public class ParsingFieldTopValue
	{
		public string FieldName { get; set; }
		public IEnumerable<Occurrence> Occurrences { get; set; }
	}
}
