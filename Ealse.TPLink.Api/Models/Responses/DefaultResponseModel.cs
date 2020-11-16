using System;
using System.Collections.Generic;
using System.Text;

namespace Ealse.TPLink.Api.Models.Responses
{
    public class DefaultResponseModel<T>
    {
        public Enums.ErrorCode Error_code { get; set; }

        public T Result { get; set; }
    }
}
