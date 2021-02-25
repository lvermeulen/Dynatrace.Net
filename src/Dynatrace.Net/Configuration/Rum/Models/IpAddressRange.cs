namespace Dynatrace.Net.Configuration.Rum.Models
{
	public class IpAddressRange
	{
		public int? SubnetMask { get; set; }
		public string Address { get; set; }
		public string AddressTo { get; set; }
	}
}
