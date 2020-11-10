using System.Collections.Generic;
using Dynatrace.Net.Common.Models;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class RequestAttribute
	{
		public ConfigurationMetadata Metadata { get; set; }
		public string Id { get; set; }
		public string Name { get; set; }
		public bool? Enabled { get; set; }
		public string DataType { get; set; }
		public IEnumerable<DataSource> DataSources { get; set; }
		public string Normalization { get; set; }
		public string Aggregation { get; set; }
		public bool? Confidential { get; set; }
		public bool? SkipPersonalDataMasking { get; set; }
	}
}
