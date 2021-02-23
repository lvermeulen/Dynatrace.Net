using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.ServiceLevelObjectives.Models
{
	public class Slo
	{
		public decimal? NumeratorValue { get; set; }
		public decimal? DenominatorValue { get; set; }
		public decimal? EvaluatedPercentage { get; set; }
		public bool? UseRateMetric { get; set; }
		public decimal? ErrorBudget { get; set; }
		public string MetricNumerator { get; set; }
		public string MetricDenominator { get; set; }
		[JsonConverter(typeof(EvaluationTypesConverter))]
		public EvaluationTypes? EvaluationType { get; set; }
		public string MetricRate { get; set; }
		public string Timeframe { get; set; }
		public string Filter { get; set; }
		public string Name { get; set; }
		public string Id { get; set; }
		public decimal? Target { get; set; }
		public string Description { get; set; }
		public bool? Enabled { get; set; }
		[JsonConverter(typeof(StatusTypesConverter))]
		public StatusTypes? Status { get; set; }
		public decimal? Warning { get; set; }
		[JsonConverter(typeof(SloErrorTypesConverter))]
		public SloErrorTypes? Error { get; set; }
	}
}
