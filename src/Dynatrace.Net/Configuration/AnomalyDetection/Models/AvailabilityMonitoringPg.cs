﻿using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.AnomalyDetection.Models
{
	public class AvailabilityMonitoringPg
	{
		[JsonConverter(typeof(AvailabilityMonitoringPgMethodsConverter))]
		public AvailabilityMonitoringPgMethods? Method { get; set; }
		public int? MinimumThreshold { get; set; }
	}
}
