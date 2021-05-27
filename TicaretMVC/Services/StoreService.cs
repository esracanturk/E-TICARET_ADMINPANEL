using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TicaretMVC.Models;

namespace TicaretMVC.Services
{
    public interface IStoreService
    {
        Task<List<Store>> GetAllStore();
        Task<Store> GetByStore(int groupid);
        Task InsertStore(Store store);
        Task UpdateStore(/*int id, */Store store);
        Task DeleteStore(int i);
    }

    public class StoreService : IStoreService
    {
        public async Task<List<Store>> GetAllStore()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:44332/Store/GetAll");
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            Store gelen = new Store();
            var result = JsonConvert.DeserializeObject<List<Store>>(responseBody);
            Console.WriteLine(result + "xxxxxxxxxxxxx");
            return result;
        }

        public async Task<Store> GetByStore(int groupid)
        {
            HttpClient client = new HttpClient();
            var result = new { groupid = groupid };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:44332/Store/GetByStore"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
            string responseBody = await response.Content.ReadAsStringAsync();
            var result2 = JsonConvert.DeserializeObject<Store>(responseBody);

            return result2;
        }

        public async Task InsertStore(Store store)
        {
            HttpClient client = new HttpClient();
            var result = new { /*groupid = store.groupid,*/ groupname = store.groupname };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost:44332/Store"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
        }

        public async Task UpdateStore(Store store)
        {
            HttpClient client = new HttpClient();
            var result = new { groupid = store.groupid, groupname = store.groupname };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {

                Method = HttpMethod.Put,
                RequestUri = new Uri("https://localhost:44332/Store"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
        }
        public async Task DeleteStore(int i)
        {
            HttpClient client = new HttpClient();
            var result = new { groupid = i };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri("https://localhost:44332/Store"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
        }
    }
}
