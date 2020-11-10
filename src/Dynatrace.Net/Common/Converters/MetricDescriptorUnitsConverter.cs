using System.Collections.Generic;
using Dynatrace.Net.Environment.MetricsV2.Models;

namespace Dynatrace.Net.Common.Converters
{
	public class MetricDescriptorUnitsConverter : JsonEnumConverter<MetricDescriptorUnits>
	{
		private static readonly Dictionary<MetricDescriptorUnits, string> s_pairs = new Dictionary<MetricDescriptorUnits, string>
		{
			[MetricDescriptorUnits.Bit] = "Bit",
			[MetricDescriptorUnits.BitPerHour] = "BitPerHour",
			[MetricDescriptorUnits.BitPerMinute] = "BitPerMinute",
			[MetricDescriptorUnits.BitPerSecond] = "BitPerSecond",
			[MetricDescriptorUnits.Byte] = "Byte",
			[MetricDescriptorUnits.BytePerHour] = "BytePerHour",
			[MetricDescriptorUnits.BytePerMinute] = "BytePerMinute",
			[MetricDescriptorUnits.BytePerSecond] = "BytePerSecond",
			[MetricDescriptorUnits.Cores] = "Cores",
			[MetricDescriptorUnits.Count] = "Count",
			[MetricDescriptorUnits.Day] = "Day",
			[MetricDescriptorUnits.DecibelMilliWatt] = "DecibelMilliWatt",
			[MetricDescriptorUnits.GibiByte] = "GibiByte",
			[MetricDescriptorUnits.Giga] = "Giga",
			[MetricDescriptorUnits.GigaByte] = "GigaByte",
			[MetricDescriptorUnits.Hour] = "Hour",
			[MetricDescriptorUnits.KibiByte] = "KibiByte",
			[MetricDescriptorUnits.KibiBytePerHour] = "KibiBytePerHour",
			[MetricDescriptorUnits.KibiBytePerMinute] = "KibiBytePerMinute",
			[MetricDescriptorUnits.KibiBytePerSecond] = "KibiBytePerSecond",
			[MetricDescriptorUnits.Kilo] = "Kilo",
			[MetricDescriptorUnits.KiloByte] = "KiloByte",
			[MetricDescriptorUnits.KiloBytePerHour] = "KiloBytePerHour",
			[MetricDescriptorUnits.KiloBytePerMinute] = "KiloBytePerMinute",
			[MetricDescriptorUnits.KiloBytePerSecond] = "KiloBytePerSecond",
			[MetricDescriptorUnits.MebiByte] = "MebiByte",
			[MetricDescriptorUnits.MebiBytePerHour] = "MebiBytePerHour",
			[MetricDescriptorUnits.MebiBytePerMinute] = "MebiBytePerMinute",
			[MetricDescriptorUnits.MebiBytePerSecond] = "MebiBytePerSecond",
			[MetricDescriptorUnits.Mega] = "Mega",
			[MetricDescriptorUnits.MegaByte] = "MegaByte",
			[MetricDescriptorUnits.MegaBytePerHour] = "MegaBytePerHour",
			[MetricDescriptorUnits.MegaBytePerMinute] = "MegaBytePerMinute",
			[MetricDescriptorUnits.MegaBytePerSecond] = "MegaBytePerSecond",
			[MetricDescriptorUnits.MicroSecond] = "MicroSecond",
			[MetricDescriptorUnits.MilliCores] = "MilliCores",
			[MetricDescriptorUnits.MilliSecond] = "MilliSecond",
			[MetricDescriptorUnits.MilliSecondPerMinute] = "MilliSecondPerMinute",
			[MetricDescriptorUnits.Minute] = "Minute",
			[MetricDescriptorUnits.Month] = "Month",
			[MetricDescriptorUnits.NanoSecond] = "NanoSecond",
			[MetricDescriptorUnits.NanoSecondPerMinute] = "NanoSecondPerMinute",
			[MetricDescriptorUnits.NotApplicable] = "N/A",
			[MetricDescriptorUnits.PerHour] = "PerHour",
			[MetricDescriptorUnits.PerMinute] = "PerMinute",
			[MetricDescriptorUnits.PerSecond] = "PerSecond",
			[MetricDescriptorUnits.Percent] = "Percent",
			[MetricDescriptorUnits.Pixel] = "Pixel",
			[MetricDescriptorUnits.Promille] = "Promille",
			[MetricDescriptorUnits.Ratio] = "Ratio",
			[MetricDescriptorUnits.Second] = "Second",
			[MetricDescriptorUnits.State] = "State",
			[MetricDescriptorUnits.Unspecified] = "Unspecified",
			[MetricDescriptorUnits.Week] = "Week",
			[MetricDescriptorUnits.Year] = "Year",
			[MetricDescriptorUnits.K] = "k",
			[MetricDescriptorUnits.Mcores] = "mCores"
		};

		protected override Dictionary<MetricDescriptorUnits, string> Pairs { get; } = s_pairs;

		protected override string EntityString { get; } = "metric descriptor unit";
	}
}
