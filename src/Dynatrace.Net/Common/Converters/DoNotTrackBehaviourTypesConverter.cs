using System.Collections.Generic;
using Dynatrace.Net.Configuration.Rum.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class DoNotTrackBehaviourTypesConverter : JsonEnumConverter<DoNotTrackBehaviourTypes>
	{
		private static readonly Dictionary<DoNotTrackBehaviourTypes, string> s_pairs = new Dictionary<DoNotTrackBehaviourTypes, string>
		{
			[DoNotTrackBehaviourTypes.CaptureAnonymized] = "CAPTURE_ANONYMIZED",
			[DoNotTrackBehaviourTypes.DoNotCapture] = "DO_NOT_CAPTURE",
			[DoNotTrackBehaviourTypes.IgnoreDoNotTrack] = "IGNORE_DO_NOT_TRACK"
		};

		protected override Dictionary<DoNotTrackBehaviourTypes, string> Pairs => s_pairs;

		protected override string EntityString => "do not track behavior type";
	}
}
