using System.Collections.Generic;

namespace Ealse.TPLink.Api.Models.Requests
{
    public class RealTimeAndSysInfoParamsModel
    {
        public GetSysInfo? System { get; set; } = new GetSysInfo();

        public Emeter? Emeter { get; set; } = new Emeter();
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
