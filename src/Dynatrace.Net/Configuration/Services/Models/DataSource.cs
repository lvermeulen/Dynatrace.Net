using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class DataSource
	{
		public bool? Enabled { get; set; }
		[JsonConverter(typeof(DataSourceSourceTypesConverter))]
		public DataSourceSourceTypes? Source { get; set; }
		public ValueProcessing ValueProcessing { get; set; }
		[JsonConverter(typeof(DataSourceTechnologiesConverter))]
		public DataSourceTechnologies? Technology { get; set; }
		[JsonConverter(typeof(SessionAttributeTechnologiesConverter))]
		public SessionAttributeTechnologies? SessionAttributeTechnology { get; set; }
		public IEnumerable<CapturedMethod> Methods { get; set; }
		public string ParameterName { get; set; }
		public ScopeConditions Scope { get; set; }
		[JsonConverter(typeof(CapturingAndStorageLocationsConverter))]
		public CapturingAndStorageLocations? CapturingAndStorageLocation { get; set; }
		[JsonConverter(typeof(IibNodeTypesConverter))]
		public IibNodeTypes? IibNodeType { get; set; }
		public ValueCondition IibMethodNodeCondition { get; set; }
		public ValueCondition CicsSdkMethodNodeCondition { get; set; }
		public ValueCondition IibLabelMethodNodeCondition { get; set; }
	}
}
