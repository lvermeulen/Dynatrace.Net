using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class KeyUserAction
	{
		public string Name { get; set; }
		[JsonConverter(typeof(KeyUserActionTypesConverter))]
		public KeyUserActionTypes? ActionType { get; set; }
		public string Domain { get; set; }
		public string MeIdentifier { get; set; }
	}
}