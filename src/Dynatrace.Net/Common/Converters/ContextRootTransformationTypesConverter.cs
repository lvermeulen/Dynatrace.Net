using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ContextRootTransformationTypesConverter : JsonEnumConverter<ContextRootTransformationTypes>
	{
		private static readonly Dictionary<ContextRootTransformationTypes, string> s_pairs = new Dictionary<ContextRootTransformationTypes, string>
		{
			[ContextRootTransformationTypes.Before] = "BEFORE",
			[ContextRootTransformationTypes.RemoveCreditCards] = "REMOVE_CREDIT_CARDS",
			[ContextRootTransformationTypes.RemoveIbans] = "REMOVE_IBANS",
			[ContextRootTransformationTypes.RemoveIps] = "REMOVE_IPS",
			[ContextRootTransformationTypes.RemoveNumbers] = "REMOVE_NUMBERS",
			[ContextRootTransformationTypes.ReplaceBetween] = "REPLACE_BETWEEN"
		};

		protected override Dictionary<ContextRootTransformationTypes, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "transformation type";
	}
}
