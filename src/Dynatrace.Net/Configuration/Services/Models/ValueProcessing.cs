namespace Dynatrace.Net.Configuration.Services.Models
{
	public class ValueProcessing
	{
		public ValueCondition ValueCondition { get; set; }
		public string ValueExtractorRegex { get; set; }
		public string SplitAt { get; set; }
		public bool? Trim { get; set; }
		public ExtractSubstring ExtractSubstring { get; set; }
	}
}
