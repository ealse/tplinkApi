using System;
using System.Collections.Generic;
using System.Text;

namespace Ealse.TPLink.Api.Models.Requests
{
    public class RequestDataParamsModel<T>
    {
        public T RequestData { get; set; }

        public string DeviceId { get; set; }
    }
}
