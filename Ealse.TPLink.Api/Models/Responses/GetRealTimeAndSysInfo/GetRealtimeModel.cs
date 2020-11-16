using System;
using System.Collections.Generic;
using System.Text;

namespace Ealse.TPLink.Api.Models.Responses
{
    public class GetRealtimeModel
    {
        public int? voltage_mv { get; set; }
        public int? current_ma { get; set; }
        public int? power_mw { get; set; }
        public int? total_wh { get; set; }
        public int? err_code { get; set; }
    }
}
