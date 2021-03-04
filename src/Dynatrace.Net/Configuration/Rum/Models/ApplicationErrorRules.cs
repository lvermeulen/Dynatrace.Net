using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class ApplicationErrorRules
	{
		public bool? IgnoreJavaScriptErrorsInApdexCalculation { get; set; }
		public bool? IgnoreHttpErrorsInApdexCalculation { get; set; }
		public bool? IgnoreCustomErrorsInApdexCalculation { get; set; }
		public IEnumerable<HttpErrorRule> HttpErrorRules { get; set; }
		public IEnumerable<CustomErrorRule> CustomErrorRules { get; set; }
	}
}
