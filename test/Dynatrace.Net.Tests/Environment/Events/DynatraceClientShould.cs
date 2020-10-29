using System.Linq;
using System.Threading.Tasks;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetEventsFeedAsync()
		{
			var result = await _client.GetEventsFeedAsync().ConfigureAwait(false);
			Assert.NotNull(result);
		}
	
		[Fact]
		public async Task GetEventAsync()
		{
			var results = await _client.GetEventsFeedAsync().ConfigureAwait(false);
			var firstResult = results.Events.FirstOrDefault();

			var result = await _client.GetEventAsync(firstResult?.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		//[Fact]
		//public async Task SendEvent()
		//{
		//	// from: https://www.dynatrace.com/news/blog/trigger-dynatrace-problem-alerts-from-external-sources-using-events-api/
		//	var result = await _client.PushEventAsync(new EventCreation
		//	{
		//		Title = "Power outage",
		//		Source = "Power control monitoring",
		//		Description = "A power outage was detected in server room 23",
		//		EventType = EventCreationEventTypes.AvailabilityEvent,
		//		AttachRules = new PushEventAttachRules
		//		{
		//			TagRule = new List<TagMatchRule>
		//			{
		//				new TagMatchRule
		//				{
		//					MeTypes = new List<MeTypes> { MeTypes.Host },
		//					Tags = new List<TagInfo> { new TagInfo { Value = "room23" }}
		//				}
		//			}
		//		},
		//		CustomProperties = new Dictionary<string, object> { ["Power out time"] = "12:00" }
		//	}).ConfigureAwait(false);
		//	Assert.NotNull(result);
		//}
	}
}
