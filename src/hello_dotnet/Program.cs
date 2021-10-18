using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Text;
namespace hello_dotnet
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            HttpResponseMessage response = await client.GetAsync("https://www.google.co.jp/");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            /*
            using (var sr = new StreamReader(await response.Content.ReadAsStreamAsync(), Encoding.GetEncoding("Shift_JIS")))
            {
                string s = sr.ReadToEnd();
                Console.WriteLine(s);
            }
            */
        }
    }
}
