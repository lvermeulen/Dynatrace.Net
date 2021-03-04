using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class ResourceTimingCaptureTypesConverter : JsonEnumConverter<ResourceTimingCaptureTypes>
	{
		private static readonly Dictionary<ResourceTimingCaptureTypes, string> s_pairs = new Dictionary<ResourceTimingCaptureTypes, string>
		{
			[ResourceTimingCaptureTypes.CaptureAllSummaries] = "CAPTURE_ALL_SUMMARIES",
			[ResourceTimingCaptureTypes.CaptureFullDetails] = "CAPTURE_FULL_DETAILS",
			[ResourceTimingCaptureTypes.CaptureLimitedSummaries] = "CAPTURE_LIMITED_SUMMARIES"
		};

		protected override Dictionary<ResourceTimingCaptureTypes, string> Pairs => s_pairs;

		protected override string EntityString => "capture type";
	}
}
