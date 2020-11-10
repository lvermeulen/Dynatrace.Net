using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class MethodReference
	{
		[JsonConverter(typeof(MethodVisibilitiesConverter))]
		public MethodVisibilities? Visibility { get; set; }
		public IEnumerable<string> Modifiers { get; set; }
		public string ClassName { get; set; }
		public string FileName { get; set; }
		public string FileNameMatcher { get; set; }
		public string MethodName { get; set; }
		public IEnumerable<string> ArgumentTypes { get; set; }
		public string ReturnType { get; set; }
	}
}
