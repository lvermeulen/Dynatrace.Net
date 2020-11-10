using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class ContextRootTransformation
	{
		[JsonConverter(typeof(ContextRootTransformationTypesConverter))]
		public ContextRootTransformationTypes? Type { get; set; }
	}
}
