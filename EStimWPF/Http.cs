using EStimWPF.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xaml.Schema;

namespace EStimWPF
{
    public class Http<T>
    {
        private string server;
        private HttpClient http;
        public Http()
        {
            this.http = new HttpClient();
            this.server = "http://localhost:8080/";
        }
        public Http(string server)
        {
            this.http=new HttpClient();
            this.server = server;
        }
        public async Task<T> Get(string serviceURL)
        {
            string cls=await http.GetStringAsync(server+serviceURL);
            return JsonSerializer.Deserialize<T>(cls);
        }
    }
}
