using System;
using System.Collections.Generic;
using System.Text;

namespace Ealse.TPLink.Api.Models.Requests
{
    public class RealTimeAndSysInfoParamsModel
    {
        public GetSysInfo? System { get; set; }

        public Emeter? Emeter { get; set; }
    }

    public class GetSysInfo
    {
        public Dictionary<string,string>? Get_sysinfo { get; set; }
    }

    public class Emeter
    {
        public Dictionary<string, string>? Get_realtime { get; set; }
    }
}
