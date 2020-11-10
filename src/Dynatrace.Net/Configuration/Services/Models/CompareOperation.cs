using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class CompareOperation
	{
		[JsonConverter(typeof(CompareOperationsConverter))]
		public CompareOperations? Type { get; set; }
	}
}
