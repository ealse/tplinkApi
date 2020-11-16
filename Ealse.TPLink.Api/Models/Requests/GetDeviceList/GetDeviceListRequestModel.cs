
using Ealse.TPLink.Api.Models.Helpers;
using System.Collections.Generic;

namespace Ealse.TPLink.Api.Models.Requests
{
    public class GetDeviceListRequestModel : DefaultRequestModel<Dictionary<string, string>>
    {
        public GetDeviceListRequestModel()
        {
            base.Method = MethodType.GetDeviceList;
        }
    }
}
