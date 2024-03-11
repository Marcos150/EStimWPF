using System.Net.Http;
using System.Text.Json;
using EStimWPF.models;

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
        public async Task<T?> Get(string serviceURL)
        {
            string cls=await http.GetStringAsync(server+serviceURL);
            return JsonSerializer.Deserialize<T>(cls);
        }
    }
}