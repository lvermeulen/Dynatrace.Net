using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class CaptureTypesConverter : JsonEnumConverter<CaptureTypes>
	{
		private static readonly Dictionary<CaptureTypes, string> s_pairs = new Dictionary<CaptureTypes, string>
		{
			[CaptureTypes.Argument] = "ARGUMENT",
			[CaptureTypes.ClassName] = "CLASS_NAME",
			[CaptureTypes.MethodName] = "METHOD_NAME",
			[CaptureTypes.Occurrences] = "OCCURRENCES",
			[CaptureTypes.SimpleClassName] = "SIMPLE_CLASS_NAME",
			[CaptureTypes.This] = "THIS"
		};

		protected override Dictionary<CaptureTypes, string> Pairs => s_pairs;

		protected override string EntityString => "capture type";
	}
}
