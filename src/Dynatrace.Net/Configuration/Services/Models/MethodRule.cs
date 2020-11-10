using System.Collections.Generic;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class MethodRule
	{
		public string Id { get; set; }
		public string MethodName { get; set; }
		public IEnumerable<string> ArgumentTypes { get; set; }
		public string ReturnType { get; set; }
	}
}
