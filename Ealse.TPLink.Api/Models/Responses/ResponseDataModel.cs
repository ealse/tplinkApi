namespace Ealse.TPLink.Api.Models.Responses
{
    public class ResponseDataModel<T> where T: new()
    {
        public T ResponseData { get; set; } = new T();
    }
}
