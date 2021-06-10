using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dynatrace.Net.Common.Models;
using Dynatrace.Net.Environment.Events.Models;
using Dynatrace.Net.Environment.ProblemsV1.Models;
using Xunit;

// ReSharper disable once CheckNamespace
namespace Dynatrace.Net.Tests
{
	public partial class DynatraceClientShould
	{
		[Fact]
		public async Task GetEventsFeedAsync()
		{
			var result = await _client.GetEventsFeedAsync(relativeTime:RelativeTimes.Week, eventType:EventTypes.CustomInfo).ConfigureAwait(false);
			Assert.NotNull(result);
		}
	
		[Fact]
		public async Task GetEventAsync()
		{
			var results = await _client.GetEventsFeedAsync().ConfigureAwait(false);
			var firstResult = results.Events.FirstOrDefault();
			if (firstResult is null)
			{
				return;
			}

			var result = await _client.GetEventAsync(firstResult.Id).ConfigureAwait(false);
			Assert.NotNull(result);
		}

		[Fact]
		public async Task SendEvent()
		{
			// from: https://www.dynatrace.com/news/blog/trigger-dynatrace-problem-alerts-from-external-sources-using-events-api/
			var result = await _client.PushEventAsync(new EventCreation
			{
				Title = "My Information",
				Source = "My System",
				Description = "Something interesting happened in my system",
				EventType = EventCreationEventTypes.CustomInfo,
				AttachRules = new PushEventAttachRules
				{
					EntityIds = new [] { "CUSTOM_APPLICATION-E1975E34652E4AD4" },
					TagRule = new []
					{
						new TagMatchRule
						{
							MeTypes = new [] { MeTypes.CustomApplication },
							Tags = new [] { new TagInfo
							{
								Key = "my-system", 
								Value = "my-information", 
								Context = TagInfoContexts.Contextless
							} }
						}
					}
				},
				CustomProperties = new Dictionary<string, object> { ["my-system"] = "my-information" }
			}).ConfigureAwait(false);

			Assert.NotNull(result);
		}
	}
}
