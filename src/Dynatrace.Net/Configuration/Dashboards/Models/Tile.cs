using Dynatrace.Net.Common.Converters;
using Newtonsoft.Json;

namespace Dynatrace.Net.Configuration.Dashboards.Models
{
	public class Tile
	{
		public string Name { get; set; }
		[JsonConverter(typeof(TileTypesConverter))]
		public TileTypes? TileType { get; set; }
		public bool? Configured { get; set; }
		public TileBounds Bounds { get; set; }
		public TileFilter TileFilter { get; set; }
	}
}
