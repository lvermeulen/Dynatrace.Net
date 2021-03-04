using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ConversionGoalTypesConverter : JsonEnumConverter<ConversionGoalTypes>
	{
		private static readonly Dictionary<ConversionGoalTypes, string> s_pairs = new Dictionary<ConversionGoalTypes, string>
		{
			[ConversionGoalTypes.Destination] = "Destination",
			[ConversionGoalTypes.UserAction] = "UserAction",
			[ConversionGoalTypes.VisitDuration] = "VisitDuration",
			[ConversionGoalTypes.VisitNumActions] = "VisitNumActions"
		};

		protected override Dictionary<ConversionGoalTypes, string> Pairs => s_pairs;

		protected override string EntityString => "conversion goal type";
	}
}
