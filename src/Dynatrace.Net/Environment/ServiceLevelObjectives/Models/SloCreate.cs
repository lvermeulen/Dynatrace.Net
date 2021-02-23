using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.ServiceLevelObjectives.Models
{
	public class SloCreate
	{
		public bool? Enabled { get; set; }
		public string Name { get; set; }
		public bool? UseRateMetric { get; set; }
		public string MetricRate { get; set; }
		public string MetricNumerator { get; set; }
		public string MetricDenominator { get; set; }
		[JsonConverter(typeof(EvaluationTypesConverter))]
		public EvaluationTypes? EvaluationType { get; set; }
		public string Filter { get; set; }
		public decimal? Target { get; set; }
		public decimal? Warning { get; set; }
		public string Timeframe { get; set; }
	}
}
