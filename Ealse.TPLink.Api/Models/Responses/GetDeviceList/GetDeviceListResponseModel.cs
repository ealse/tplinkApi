using System.Collections.Generic;

namespace Ealse.TPLink.Api.Models.Responses
{
    public class GetDeviceListResponseModel : DefaultResponseModel<DeviceListModel> { }

    public class DeviceListModel
    {
        public IList<TPLinkDeviceModel>? DeviceList { get; set; }
    }
}
