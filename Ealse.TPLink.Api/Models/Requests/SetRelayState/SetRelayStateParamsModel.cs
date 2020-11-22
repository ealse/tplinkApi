namespace Ealse.TPLink.Api.Models.Requests
{
    public class SetRelayStateParamsModel
    {
        public SetRelayState? System { get; set; }
    }

    public class SetRelayState
    {
        public RelayState? Set_relay_state { get; set; }
    }

    public class RelayState
    {
        public int? State { get; set; }
    }
}
