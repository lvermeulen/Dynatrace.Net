using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class TransformationBase
	{
		[JsonConverter(typeof(TransformationBaseTypesConverter))]
		public TransformationBaseTypes? Type { get; set; }
	}
}
