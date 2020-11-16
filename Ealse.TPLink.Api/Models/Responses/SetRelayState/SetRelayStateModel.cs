using System;
using System.Collections.Generic;
using System.Text;

namespace Ealse.TPLink.Api.Models.Responses
{
    public class SetRelayStateModel
    {
        public SetRelayStateResponse? System { get; set; }
    }

    public class SetRelayStateResponse
    {
        public Tuple<string, int>? Set_relay_state { get; set; }
    }
}
