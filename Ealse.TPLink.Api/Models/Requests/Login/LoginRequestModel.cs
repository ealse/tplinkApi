using Ealse.TPLink.Api.Models.Helpers;

namespace Ealse.TPLink.Api.Models.Requests
{
    public class LoginRequestModel : DefaultRequestModel<LoginParamsModel>
    {
        public LoginRequestModel()
        {
            base.Method = MethodType.Login;
        }
    }
}
