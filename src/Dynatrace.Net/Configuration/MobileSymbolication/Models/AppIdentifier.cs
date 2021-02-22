using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.MobileSymbolication.Models
{
	public class AppIdentifier
	{
		public string Id { get; set; }
		public string VersionCode { get; set; }
		public string VersionName { get; set; }
		public string PackageName { get; set; }
		[JsonConverter(typeof(MobileOsTypesConverter))]
		public MobileOsTypes? Os { get; set; }
	}
}
