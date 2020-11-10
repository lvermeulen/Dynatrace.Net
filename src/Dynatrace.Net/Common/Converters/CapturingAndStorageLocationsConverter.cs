using System.Collections.Generic;
using Dynatrace.Net.Configuration.Services.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class CapturingAndStorageLocationsConverter : JsonEnumConverter<CapturingAndStorageLocations>
	{
		private static readonly Dictionary<CapturingAndStorageLocations, string> s_pairs = new Dictionary<CapturingAndStorageLocations, string>
		{
			[CapturingAndStorageLocations.CaptureAndStoreOnBoth] = "CAPTURE_AND_STORE_ON_BOTH",
			[CapturingAndStorageLocations.CaptureAndStoreOnClient] = "CAPTURE_AND_STORE_ON_CLIENT",
			[CapturingAndStorageLocations.CaptureAndStoreOnServer] = "CAPTURE_AND_STORE_ON_SERVER",
			[CapturingAndStorageLocations.CaptureOnClientStoreOnServer] = "CAPTURE_ON_CLIENT_STORE_ON_SERVER"
		};
		
		protected override Dictionary<CapturingAndStorageLocations, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "capturing and storage location";
	}
}
