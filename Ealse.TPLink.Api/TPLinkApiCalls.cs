using System;
using System.Threading.Tasks;
using Ealse.TPLink.Api.Models.Responses;
using Ealse.TPLink.Api.Models.Requests;

namespace Ealse.TPLink.Api
{
    public partial class TPLinkClient : IDisposable
    {
        public async Task<GetDeviceListResponseModel?> GetDevicesAsync()
        {
            return await SendAsync<GetDeviceListRequestModel, GetDeviceListResponseModel>();
        }

        public async Task<GetRealTimeAndSysInfoResponseModel?> GetRealTimeAndSysInfoAsync(string deviceId)
        {
            var requestBody = new GetRealTimeAndSysInfoRequestModel { 
                Params = new RequestDataParamsModel<RealTimeAndSysInfoParamsModel> { 

                    DeviceId = deviceId 
                }  
            };
            return await SendAsync<GetRealTimeAndSysInfoRequestModel, GetRealTimeAndSysInfoResponseModel>(requestBody);
        }

        public async Task<LoginResponseModel?> LoginAsync(string username, string password)
        {
            var requestBody = new LoginRequestModel
            {
                Params = new LoginParamsModel()
                {
                    CloudUserName = username,
                    CloudPassword = password,
                    TerminalUUID = Guid.NewGuid()
                }
            };

            return await SendAsync<LoginRequestModel, LoginResponseModel>(requestBody);
        }

        public async Task<SetRelayStateResponseModel?> SetRelayStateAsync(string deviceId, int relayState)
        {
            var requestBody = new SetRelayStateRequestModel
            {
                Params = new RequestDataParamsModel<SetRelayStateParamsModel>
                {
                    RequestData = new SetRelayStateParamsModel
                    {
                        System = new SetRelayState
                        {
                            Set_relay_state = new RelayState { State = relayState }
                        }
                    },
                    DeviceId = deviceId
                }
            };

            return await SendAsync<SetRelayStateRequestModel, SetRelayStateResponseModel>(requestBody);
        }
    }
}

