using System.Security.Cryptography.X509Certificates;
using Wms.Integration.WebUI.Models;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Wms.Integration.UI.Helpers
{
    public class ApiHelper
    {
        private static ResultViewModel result;
        public static ResultViewModel Result { get => result ?? (result = new ResultViewModel()); }
        public static string Url = "http://localhost/api/";
        public static async Task<ResultViewModel> GetAsync<T>(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage message = await client.GetAsync(url);
                if (message.IsSuccessStatusCode)
                {
                    Result.Result = true;
                    Result.Message = "Başarılı bir şekil de getirildi...";
                    Result.Data = JsonConvert.DeserializeObject<T>(await message.Content.ReadAsStringAsync());
                }
                else
                {
                    Result.Result = false;
                    Result.Message = await message.Content.ReadAsStringAsync();
                    Result.Data = null;
                }
            }
            return Result;
        }
        public static async Task<ResultViewModel> GetListAsync<T>(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage message = await client.GetAsync(url);
                if (message.IsSuccessStatusCode)
                {
                    Result.Result = true;
                    Result.Message = "Başarılı bir şekil de getirildi...";
                    Result.Data = JsonConvert.DeserializeObject<IList<T>>(await message.Content.ReadAsStringAsync());
                }
                else
                {
                    Result.Result = false;
                    Result.Message = await message.Content.ReadAsStringAsync();
                    Result.Data = null;
                }
            }
            return Result;
        }
        public static async Task<ResultViewModel> PostAsync<T>(string url, T entity)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage message = await client.PostAsJsonAsync(url,entity);
                if (message.IsSuccessStatusCode)
                {
                    Result.Result = true;
                    Result.Message = "Başarılı bir şekil de veri eklendi!";
                    Result.Data = JsonConvert.DeserializeObject<T>(await message.Content.ReadAsStringAsync());
                }
                else
                {
                    Result.Result = false;
                    Result.Message = await message.Content.ReadAsStringAsync();
                    Result.Data = null;
                }
            }
            return Result;
        }
        public static async Task<ResultViewModel> UpdateAsync<T>(string url, T entity)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage message = await client.PutAsJsonAsync(url, entity);
                if (message.IsSuccessStatusCode)
                {
                    Result.Result = true;
                    Result.Message = "Başarılı bir şekil de güncellendi!";
                    Result.Data = JsonConvert.DeserializeObject<T>(await message.Content.ReadAsStringAsync());
                }
                else
                {
                    Result.Result = false;
                    Result.Message = await message.Content.ReadAsStringAsync();
                    Result.Data = null;
                }
            }
            return Result;
        }
        public static async Task<ResultViewModel> DeleteAsync<T>(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage message = await client.DeleteAsync(url);
                if (message.IsSuccessStatusCode)
                {
                    Result.Result = true;
                    Result.Message = "Başarılı bir şekil de silindi!";
                    Result.Data = JsonConvert.DeserializeObject<T>(await message.Content.ReadAsStringAsync());
                }
                else
                {
                    Result.Result = false;
                    Result.Message = await message.Content.ReadAsStringAsync();
                    Result.Data = null;
                }
            }
            return Result;
        }
    }
}
