using System.Net.Http;
using System.Threading.Tasks;

namespace dotnet_tcpdump
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var handler = new HttpClientHandler { };

            var client = new HttpClient(handler);

            await client.GetAsync(args[0]);
        }
    }
}
