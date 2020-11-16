using System;
using System.Collections.Generic;
using System.Text;

namespace Ealse.TPLink.Api.Models.Responses
{
    public class GetSysInfoModel
	{
		public string? sw_ver { get; set; }

		public string? hw_ver { get; set; }

		public string? model { get; set; }

		public string? deviceId { get; set; }

		public string? oemId { get; set; }

		public string? hwId { get; set; }

		public int? rssi { get; set; }

		public int? longitude_i { get; set; }

		public int? latitude_i { get; set; }

		public string? alias { get; set; }

		public string? status { get; set; }

		public string? mic_type { get; set; }

		public string? feature { get; set; }

		public string? mac { get; set; }

		public int? updating { get; set; }

		public int? led_off { get; set; }

		public int? relay_state { get; set; }

		public int? on_time { get; set; }

		public string? active_mode { get; set; }

		public string? icon_hash { get; set; }

		public string? dev_name { get; set; }

		public NextActionObject? next_action { get; set; }

		public int? ntc_state { get; set; }

		public int? err_code { get; set; }

		public class NextActionObject
		{
			public int? type { get; set; }
		}
	}
}
