namespace Ealse.TPLink.Api.Models.Responses
{
    public class DefaultResponseModel<T> where T : new()
    {
        public Enums.ErrorCode Error_code { get; set; }

        public T Result { get; set; } = new T();
    }
}
