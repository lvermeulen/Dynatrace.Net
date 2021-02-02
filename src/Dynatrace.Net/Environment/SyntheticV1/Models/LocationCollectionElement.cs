using System.Collections.Generic;
using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Environment.SyntheticV1.Models
{
	public class LocationCollectionElement
	{
		public string Name	{get;set; }
		public string EntityId	{get;set;}
		[JsonConverter(typeof(SyntheticLocationTypesConverter))]
		public SyntheticLocationTypes? Type	{get;set;}
		[JsonConverter(typeof(CloudPlatformsConverter))]
		public CloudPlatforms? CloudPlatform	{get;set;}
		public IEnumerable<string> Ips	{get;set;}
		[JsonConverter(typeof(ReleaseStagesConverter))]
		public ReleaseStages? Stage	{get;set;}
		[JsonConverter(typeof(SyntheticLocationStatusTypesConverter))]
		public SyntheticLocationStatusTypes? Status	{get;set;}
	}
}
