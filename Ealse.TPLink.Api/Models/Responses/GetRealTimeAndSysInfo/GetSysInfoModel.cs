namespace Ealse.TPLink.Api.Models.Responses
{
    public class GetSysInfoModel
	{
		public string? Sw_ver { get; set; }

		public string? Hw_ver { get; set; }

		public string? Model { get; set; }

		public string? DeviceId { get; set; }

		public string? OemId { get; set; }

		public string? HwId { get; set; }

		public int? Rssi { get; set; }

		public int? Longitude_i { get; set; }

		public int? Latitude_i { get; set; }

		public string? Alias { get; set; }

		public string? Status { get; set; }

		public string? Mic_type { get; set; }

		public string? Feature { get; set; }

		public string? Mac { get; set; }

		public int? Updating { get; set; }

		public int? Led_off { get; set; }

		public int? Relay_state { get; set; }

		public int? On_time { get; set; }

		public string? Active_mode { get; set; }

		public string? Icon_hash { get; set; }

		public string? Dev_name { get; set; }

		public NextActionObject? Next_action { get; set; }

		public int? Ntc_state { get; set; }

		public int? Err_code { get; set; }

		public class NextActionObject
		{
			public int? Type { get; set; }
		}
	}
}
