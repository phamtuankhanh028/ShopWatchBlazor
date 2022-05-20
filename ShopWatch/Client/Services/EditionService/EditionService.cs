using ShopWatch.Shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ShopWatch.Client.Services.EditionService
{
    public class EditionService : IEditionService
    {
        private readonly HttpClient _http;

        public EditionService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Edition>> GetEditions()
        {
            return await _http.GetFromJsonAsync<List<Edition>>("api/edition");
        }
    }
}
