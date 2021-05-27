using Microsoft.AspNetCore.Mvc;
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
    public interface IUsersService
    {
        Task<List<Users>> GetAllUser();
        Task<List<Store>> GetAllStore();
        Task<Users> GetByUser(int userid);
        Task<Users> FindUser(Users user);
        Task<Users> FindEmail(Users user);
        Task InsertUser(Users user);
        Task RegisterUser(Users user);
        Task UpdateUser(/*int id, */Users user);
        Task DeleteUser(int i);

        //Task Insert(User user);
        //Task<List<User>> Show();
        //Task Update(/*int id, */User user);
    }
    public class UsersService : IUsersService
    {
        public async Task<List<Users>> GetAllUser()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:44332/Users/GetAll");
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            Users gelen = new Users();
            var result = JsonConvert.DeserializeObject<List<Users>>(responseBody);
            Console.WriteLine(result + "xxxxxxxxxxxxx");
            return result;
        }

        public async Task<List<Store>> GetAllStore()
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync("https://localhost:44332/Store/GetAll");
            string responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseBody);
            var result = JsonConvert.DeserializeObject<List<Store>>(responseBody);
            Console.WriteLine(result + "xxxxxxxxxxxxx");
            return result;
        }

        public async Task<Users> FindUser(Users user)
        {
            HttpClient client = new HttpClient();
            var result = new { username = user.username, password = user.password };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:44332/Users/FindUser"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
            string responseBody = await response.Content.ReadAsStringAsync();
            var result2 = JsonConvert.DeserializeObject<Users>(responseBody);

            return result2;
        }

        public async Task<Users> FindEmail(Users user)
        {
            HttpClient client = new HttpClient();
            var result = new { email=user.email };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:44332/Users/FindEmail"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
            string responseBody = await response.Content.ReadAsStringAsync();
            var result2 = JsonConvert.DeserializeObject<Users>(responseBody);

            return result2;
        }

        public async Task<Users> GetByUser(int userid)
        {
            HttpClient client = new HttpClient();
            var result = new { userid = userid };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:44332/Users/GetById"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
            string responseBody = await response.Content.ReadAsStringAsync();
            var result2 = JsonConvert.DeserializeObject<Users>(responseBody);

            return result2;
        }
        public async Task InsertUser(Users user)
        {
            HttpClient client = new HttpClient();
            var result = new
            { /*userid = user.userid,*/
                username = user.username,
                password = user.password,
                role = user.role,
                email = user.email,
                emailconfirm = user.emailconfirm
            };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost:44332/Users"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
        }

        public async Task RegisterUser(Users user)
        {
            HttpClient client = new HttpClient();
            var result = new
            { /*userid = user.userid,*/
                username = user.username,
                password = user.password,
                role = user.role,
                email = user.email,
                emailconfirm = user.emailconfirm
            };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://localhost:44332/Users"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
        }

        public async Task UpdateUser(Users user)
        {
            HttpClient client = new HttpClient();
            var result = new
            {
                userid = user.userid,
                username = user.username,
                password = user.password,
                role = user.role,
                email = user.email,
                emailconfirm = user.emailconfirm
            };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {

                Method = HttpMethod.Put,
                RequestUri = new Uri("https://localhost:44332/Users/UpdateUser"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
        }

        public async Task DeleteUser(int i)
        {
            HttpClient client = new HttpClient();
            var result = new { userid = i };
            var json = JsonConvert.SerializeObject(result);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri("https://localhost:44332/Users"),
                Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            var response = await client.SendAsync(request).ConfigureAwait(false);
        }
    }
}
