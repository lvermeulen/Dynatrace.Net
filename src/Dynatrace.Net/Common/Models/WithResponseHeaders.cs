namespace Dynatrace.Net.Common.Models
{
	public class WithResponseHeaders<T>
	{
		public int? TotalCount { get; set; }
		public string NextPageKey { get; set; }
		public string PageSize { get; set; }
		public T Instance { get; set; }
	}
}
