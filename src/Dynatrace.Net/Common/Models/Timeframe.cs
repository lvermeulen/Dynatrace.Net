namespace Dynatrace.Net.Common.Models
{
	public class Timeframe
	{
		protected long UtcMilliseconds { get; private set; }
		protected string AbsoluteTimeframe { get; private set; }
		protected string RelativeTimeframe { get; private set; }
		protected TimeframeStrategy Strategy { get; private set; }

		protected enum TimeframeStrategy
		{
			UtcMilliseconds,
			AbsoluteTimeframe,
			RelativeTimeframe
		}

		public static Timeframe FromUtcMilliseconds(long utcMilliseconds) => new Timeframe
		{
			UtcMilliseconds = utcMilliseconds,
			Strategy = TimeframeStrategy.UtcMilliseconds
		};

		public static Timeframe FromAbsoluteTime(string absoluteTimeframe) => new Timeframe
		{
			AbsoluteTimeframe = absoluteTimeframe,
			Strategy = TimeframeStrategy.AbsoluteTimeframe
		};

		public static Timeframe FromRelativeTime(string relativeTimeframe) => new Timeframe
		{
			RelativeTimeframe = relativeTimeframe,
			Strategy = TimeframeStrategy.RelativeTimeframe
		};

		protected Timeframe()
		{ }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Major Bug", "S3923:All branches in a conditional structure should not have exactly the same implementation", Justification = "<Pending>")]
		public override string ToString()
		{
			switch (Strategy)
			{
				case TimeframeStrategy.UtcMilliseconds: return UtcMilliseconds.ToString();
				case TimeframeStrategy.AbsoluteTimeframe: return AbsoluteTimeframe;
				default: return RelativeTimeframe;
			}
		}
	}
}
