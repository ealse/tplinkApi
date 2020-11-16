using System;
using System.Collections.Generic;
using System.Text;

namespace Ealse.TPLink.Api.Models.Requests
{
    public class LoginParamsModel
    {
        public string? AccountId { get; set; }

        public string? RegTime { get; set; }

        public string? Email { get; set; }

        public string? Token { get; set; }
    }
}
