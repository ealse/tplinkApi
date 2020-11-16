using Ealse.TPLink.Api;
using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (var client = new TPLinkClient("",""))
            {
                var b = await client.GetDevicesAsync("64c98cf9-BTHE3H5Uwm6kF8zJGLM7Zcg");
                Console.WriteLine(b);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
