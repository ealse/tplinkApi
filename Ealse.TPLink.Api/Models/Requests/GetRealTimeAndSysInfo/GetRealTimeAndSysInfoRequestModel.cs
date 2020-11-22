using Ealse.TPLink.Api.Models.Helpers;

namespace Ealse.TPLink.Api.Models.Requests
{
    public class GetRealTimeAndSysInfoRequestModel : DefaultRequestModel<RequestDataParamsModel<RealTimeAndSysInfoParamsModel>>
    {
        public GetRealTimeAndSysInfoRequestModel()
        {
            base.Method = MethodType.Passthrough;
        }
    }
}
