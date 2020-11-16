using Ealse.TPLink.Api.Models.Helpers;

namespace Ealse.TPLink.Api.Models.Requests
{
    public class SetRelayStateRequestModel : DefaultRequestModel<RequestDataParamsModel<SetRelayStateParamsModel>>
    {
        public SetRelayStateRequestModel()
        {
            base.Method = MethodType.Passthrough;
        }
    }
}
