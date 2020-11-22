namespace Ealse.TPLink.Api.Models.Responses
{
    public class SetRelayStateModel
    {
        public SetRelayStateResponse? System { get; set; }
    }

    public class SetRelayStateResponse
    {
        public RelayStateResponse? Set_relay_state { get; set; }
    }

    public class RelayStateResponse
    {
        public int? Err_code { get; set; }
    }
}