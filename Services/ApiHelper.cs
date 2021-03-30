using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Services
{
    public class ApiHelper
    {
        public static HttpClient client;
        public static bool HasInitialized { get; set; } = false;

        public static void InitClient()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HasInitialized = true;
        }
    }
}
