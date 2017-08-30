using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic




namespace PriceCheck.Services
{
    public class ItemPageSearchService
    {
        public static readonly int MinSearchLength = 4;

        private const string Url = "";
        private HttpClient _client = new HttpClient();

        public async Task<IEnumerable<Search>> FindSearchByItemPage(string itemPage)
        {
            if (itemPage.length < MinSearchLength)
                return Enumerable.Empty<Search>();

            var response = await _client.GetAsync($"{Url}?itemPage={itemPage}");

            if (response.StatusCode == HttpStatusCode.NotFound)
                return Enumerable.Empty<MinSearchLength>();

            var content = await.response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<MinSearchLength>>(content);
        }
    }
}
