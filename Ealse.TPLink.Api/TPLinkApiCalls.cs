using System;
using System.Threading.Tasks;
using Ealse.TPLink.Api.Models.Responses;
using Ealse.TPLink.Api.Models.Requests;

namespace Ealse.TPLink.Api
{
    public partial class TPLinkClient : IDisposable
    {
        public async Task<GetDeviceListResponseModel> GetDevicesAsync(string token)
        {
            return await SendAsync<GetDeviceListRequestModel, GetDeviceListResponseModel>(new Uri($"{this.TPLinkApiBaseUrl}?token={token}"));
        }

        public async Task<GetRealTimeAndSysInfoResponseModel> GetRealTimeAndSysInfoAsync(string token)
        {
            return await SendAsync<GetRealTimeAndSysInfoRequestModel, GetRealTimeAndSysInfoResponseModel>(new Uri($"{this.TPLinkApiBaseUrl}?token={token}"));
        }

        public async Task<LoginResponseModel> LoginAsync(string token)
        {
            return await SendAsync<LoginRequestModel, LoginResponseModel > (new Uri($"{this.TPLinkApiBaseUrl}?token={token}"));
        }

        public async Task<SetRelayStateResponseModel> SetRelayStateAsync(string token)
        {
            return await SendAsync<SetRelayStateRequestModel, SetRelayStateResponseModel>(new Uri($"{this.TPLinkApiBaseUrl}?token={token}"));
        }
    }
}

