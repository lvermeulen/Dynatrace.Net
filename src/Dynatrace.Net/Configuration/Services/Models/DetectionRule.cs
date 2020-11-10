using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class DetectionRule
	{
		public string Id { get; set; }
		public bool? Enabled { get; set; }
		[JsonConverter(typeof(MatchersConverter))]
		public Matchers? FileName { get; set; }
		[JsonConverter(typeof(FileNameMatchersConverter))]
		public FileNameMatchers? FileNameMatcher { get; set; }
		public string ClassName { get; set; }
		public string Matcher { get; set; }
		public IEnumerable<MethodRule> MethodRules { get; set; }
		public IEnumerable<string> Annotations { get; set; }
	}
}
