using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Dynatrace.Net.Configuration.CalculatedMetrics.Models;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.UserSessions.Models
{
	public class UserSession
	{
		public string TenantId { get; set; }
		public string UserSessionId { get; set; }
		public int? StartTime { get; set; }
		public int? EndTime { get; set; }
		public int? Duration { get; set; }
		public string InternalUserId { get; set; }
		[JsonConverter(typeof(UserTypesConverter))]
		public UserTypes? UserType { get; set; }
		[JsonConverter(typeof(NoSessionReplayReasonsConverter))]
		public NoSessionReplayReasons? ReasonForNoSessionReplay { get; set; }
		[JsonConverter(typeof(ApplicationTypesConverter))]
		public ApplicationTypes? ApplicationType { get; set; }
		public bool? Bounce { get; set; }
		public bool? NewUser { get; set; }
		public int? UserActionCount { get; set; }
		public int? TotalErrorCount { get; set; }
		public int? TotalLicenseCreditCount { get; set; }
		public int? MatchingConversionGoalsCount { get; set; }
		public IEnumerable<string> MatchingConversionGoals { get; set; }
		public string Ip { get; set; }
		public string Continent { get; set; }
		public string Country { get; set; }
		public string Region { get; set; }
		public string City { get; set; }
		public string BrowserType { get; set; }
		public string BrowserFamily { get; set; }
		public string BrowserMajorVersion { get; set; }
		public string OsFamily { get; set; }
		public string OsVersion { get; set; }
		public string Manufacturer { get; set; }
		public string Device { get; set; }
		public string UserId { get; set; }
		public int? ScreenHeight { get; set; }
		public int? ScreenWidth { get; set; }
		[JsonConverter(typeof(OrientationTypesConverter))]
		public OrientationTypes? ScreenOrientation { get; set; }
		[JsonConverter(typeof(ResolutionTypesConverter))]
		public ResolutionTypes? DisplayResolution { get; set; }
		public bool? HasCrash { get; set; }
		public bool? HasSessionReplay { get; set; }
		public string Isp { get; set; }
		public string ClientType { get; set; }
		public string BrowserMonitorId { get; set; }
		public string BrowserMonitorName { get; set; }
		public IEnumerable<StringProperty> StringProperties { get; set; }
		public IEnumerable<LongProperty> LongProperties { get; set; }
		public IEnumerable<DoubleProperty> DoubleProperties { get; set; }
		public IEnumerable<DateProperty> DateProperties { get; set; }
		public IEnumerable<UserSessionUserAction> UserActions { get; set; }
		public IEnumerable<UserSessionEvents> Events { get; set; }
		public IEnumerable<UserSessionErrors> Errors { get; set; }
		public IEnumerable<UserSessionSyntheticEvent> SyntheticEvents { get; set; }
		public string AppVersion { get; set; }
		[JsonConverter(typeof(EndReasonsConverter))]
		public EndReasons? EndReason { get; set; }
		public int? NumberOfRageClicks { get; set; }
		[JsonConverter(typeof(ApdexTypesConverter))]
		public ApdexTypes? UserExperienceScore { get; set; }
		public string Carrier { get; set; }
		public string NetworkTechnology { get; set; }
		[JsonConverter(typeof(ConnectionTypesConverter))]
		public ConnectionTypes? ConnectionType { get; set; }
		public int? ReplayStart { get; set; }
		public int? ReplayEnd { get; set; }
		public int? ClientTimeOffset { get; set; }
	}
}
