using System;
using System.Collections.Generic;
using System.Text;

namespace Ealse.TPLink.Api.Models.Responses
{
    public class LoginModel
    {
		public string? accountId { get; set; }
		public string? regTime { get; set; }
		public string? email { get; set; }
		public string? token { get; set; }
	}
}
