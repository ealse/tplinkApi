namespace Ealse.TPLink.Api.Models.Responses
{
    public class GetRealtimeModel
    {
        public int? Voltage_mv { get; set; }
        public int? Current_ma { get; set; }
        public int? Power_mw { get; set; }
        public int? Total_wh { get; set; }
        public int? Err_code { get; set; }
    }
}
