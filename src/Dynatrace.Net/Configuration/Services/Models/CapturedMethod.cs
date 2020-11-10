using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Services.Models
{
	public class CapturedMethod
	{
		public MethodReference Method { get; set; }
		[JsonConverter(typeof(CaptureTypesConverter))]
		public CaptureTypes? Capture { get; set; }
		public int? ArgumentIndex { get; set; }
		public string DeepObjectAccess { get; set; }
	}
}
