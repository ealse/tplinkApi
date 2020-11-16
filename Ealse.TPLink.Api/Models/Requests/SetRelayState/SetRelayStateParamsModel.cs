using System;
using System.Collections.Generic;
using System.Text;

namespace Ealse.TPLink.Api.Models.Requests
{
    public class SetRelayStateParamsModel
    {
        public SetRelayState? System { get; set; }
    }

    public class SetRelayState
    {
        public Tuple<string,int>? Set_relay_state { get; set; }
    }
}
