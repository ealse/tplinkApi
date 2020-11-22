namespace Ealse.TPLink.Api.Models.Requests
{
    public class DefaultRequestModel<T> where T : new()
    {
        public string? Method { get; set; }

        public T Params { get; set; } = new T();
    }
}
