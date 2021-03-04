using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class UserActionNamingPlaceholder
	{
		public string Name { get; set; }
		[JsonConverter(typeof(NamingPlaceholderInputTypesConverter))]
		public NamingPlaceholderInputTypes? Input { get; set; }
		[JsonConverter(typeof(ProcessingPartsConverter))]
		public ProcessingParts? ProcessingPart { get; set; }
		public IEnumerable<UserActionNamingPlaceholderProcessingStep> ProcessingSteps { get; set; }
		public int? MetadataId { get; set; }
		public bool? UseGuessedElementIdentifier { get; set; }
	}
}
