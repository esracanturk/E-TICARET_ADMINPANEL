using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TicaretMVC.Models;

namespace TicaretMVC.Services
{
    public interface IProductsService
    {
        Task<List<ProductsWithStore>> GetAllProduct(ProductsWithStore Product);
        Task<List<Store>> GetAllStore();
        Task<ProductsWithStore> GetByProduct(int Id);
        Task InsertProduct(ProductsWithStore product);
        Task UpdateProduct(int Id,ProductsWithStore product);
        Task DeleteProduct(int i);

    }
    public class ProductsService : IProductsService
    {
        public async Task<List<ProductsWithStore>> GetAllProduct(ProductsWithStore product)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:44332/Products/GetAll");
            //HttpResponseMessage response = await client.GetAsync("http://192.168.1.102:28571/api/Product/GetAll");
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            var result = JsonConvert.DeserializeObject<List<ProductsWithStore>>(responseBody);
            return result;
        }

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

        public async Task<ProductsWithStore> GetByProduct(int Id)
        {
            HttpClient client = new HttpClient();
            var result = new { Id = Id };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:44332/Products/GetByProduct"),
                //RequestUri = new Uri("http://192.168.1.102:28571/api/Product/GetById"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
            string responseBody = await response.Content.ReadAsStringAsync();
            var result2 = JsonConvert.DeserializeObject<ProductsWithStore>(responseBody);

            return result2;
        }

        public async Task InsertProduct(ProductsWithStore product)
        {
            HttpClient client = new HttpClient();
            var result = new
            {
                Id = product.Id,
                Name = product.Name,
                Quantity = product.Quantity,
                ImageUrl = product.ImageUrl,
                Description=product.Description,
                Price = product.Price,
                groupid = product.groupid
                //KategoriID = product.KategoriID,
                //KategoriName = product.KategoriName
            };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost:44332/Products"),
                //RequestUri = new Uri("http://192.168.1.102:28571/api/Product"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
        }
        public async Task UpdateProduct(int Id,ProductsWithStore product)
        {
            HttpClient client = new HttpClient();
            var result = new
            {
                Id = Id,
                Name = product.Name,
                Quantity = product.Quantity,
                Price = product.Price,
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                groupid = product.groupid,
                groupname = product.groupname
                //KategoriID = product.KategoriID,
                //KategoriName = product.KategoriName
            };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {

                Method = HttpMethod.Put,
                RequestUri = new Uri("https://localhost:44332/Products"),
                //RequestUri = new Uri("http://192.168.1.102:28571/api/Product"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
        }

        public async Task DeleteProduct(int i)
        {
            HttpClient client = new HttpClient();
            var result = new { Id = i };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri("https://localhost:44332/Products"),
                //RequestUri = new Uri("http://192.168.1.102:28571/api/Product"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
        }
    }
}
