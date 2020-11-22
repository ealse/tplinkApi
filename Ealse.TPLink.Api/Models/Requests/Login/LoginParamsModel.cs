using System;

namespace Ealse.TPLink.Api.Models.Requests
{
    public class LoginParamsModel
    {
        public string? AppType => "Kasa_Android";

        public string? CloudUserName { get; set; }

        public string? CloudPassword { get; set; }

        public Guid? TerminalUUID { get; set; }
    }
}
