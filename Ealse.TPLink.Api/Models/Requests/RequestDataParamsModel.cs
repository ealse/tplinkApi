namespace Ealse.TPLink.Api.Models.Requests
{
    public class RequestDataParamsModel<T> where T: new()
    {
        public T RequestData { get; set; } = new T();

        public string? DeviceId { get; set; }
    }
}
