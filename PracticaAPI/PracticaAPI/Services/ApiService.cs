using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PracticaAPI.Models;

namespace PracticaAPI.Services
{
    class ApiService : IApiService
    {
        public const string Key = "AIzaSyC53qhhXAmPOsxc34WManoorp7SVN_Qezo";

        public async Task<Place> GetLocation(string Texto)
        {
            HttpClient Client = new HttpClient();
            String Response = await Client.GetStringAsync($"https://maps.googleapis.com/maps/api/place/findplacefromtext/json?input={Texto}&inputtype=textquery&fields=formatted_address%2Cname%2Crating%2Cgeometry&key={Key}");

            return JsonConvert.DeserializeObject<Place>(Response);
        }
    }
}
