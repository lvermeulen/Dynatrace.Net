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

		public override string ToString()
		{
			return Strategy switch
			{
				TimeframeStrategy.UtcMilliseconds => UtcMilliseconds.ToString(),
				TimeframeStrategy.AbsoluteTimeframe => AbsoluteTimeframe,
				var _ => RelativeTimeframe
			};
		}
	}
}
