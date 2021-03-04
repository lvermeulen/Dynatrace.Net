using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class ConversionGoal
	{
		public string Name { get; set; }
		public string Id { get; set; }
		[JsonConverter(typeof(ConversionGoalTypesConverter))]
		public ConversionGoalTypes? Type { get; set; }
		public DestinationDetails DestinationDetails { get; set; }
		public UserActionDetails UserActionDetails { get; set; }
		public VisitDurationDetails VisitDurationDetails { get; set; }
		public VisitNumActionDetails VisitNumActionDetails { get; set; }
	}
}
