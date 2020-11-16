using System.Collections.Generic;

namespace Ealse.TPLink.Api.Models.Requests
{
    public class DefaultRequestModel<T> 
    {
        public string? Method { get; set; }

        public T Params { get; set; }
    }
}
