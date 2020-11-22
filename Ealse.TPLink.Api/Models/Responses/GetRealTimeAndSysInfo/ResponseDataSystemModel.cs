namespace Ealse.TPLink.Api.Models.Responses
{
    public class ResponseDataSystemModel<T1, T2> where T1 : class, new() where T2 : class, new()
    {
        public SystemObject<T1> System { get; set; } = new SystemObject<T1>();

        public Emeter<T2> Emeter { get; set; } = new Emeter<T2>();
    }

    public class SystemObject<T> where T : new()
    {
        public T Get_sysinfo { get; set; } = new T();
    }

    public class Emeter<T> where T : new()
    {
        public T Get_realtime { get; set; } = new T();
    }

}