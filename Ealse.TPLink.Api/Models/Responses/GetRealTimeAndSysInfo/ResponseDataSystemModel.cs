using System;
using System.Collections.Generic;
using System.Text;

namespace Ealse.TPLink.Api.Models.Responses
{
    public class ResponseDataSystemModel<T1, T2>
    {
        public T1 System { get; set; }

        public T2 Emeter { get; set; }
    }
}
