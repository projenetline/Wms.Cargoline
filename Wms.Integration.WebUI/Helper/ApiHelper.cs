using System.Net.Http.Headers;
using Wms.Integration.WebUI.Models;

namespace Wms.Integration.WebUI.Helper
{
    public class ApiHelper
    {
        private static string baseAddress = "http://localhost:8080/";
        private static ResultViewModel resultViewModel;
        public static ResultViewModel ResultViewModel => resultViewModel ?? (resultViewModel= new ResultViewModel());
        public static async Task<ResultViewModel> GetAsync(string uri)
        {
            using(HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage message = await client.GetAsync(uri);

                if(message.IsSuccessStatusCode)
                {
                    ResultViewModel.Result = true;
                    ResultViewModel.Message = "Başarılı bir şekil de getirildi.";
                    ResultViewModel.Data = await message.Content.ReadAsStringAsync();
                }
                else
                {
                    ResultViewModel.Result = false;
                    ResultViewModel.Message = await message.Content.ReadAsStringAsync();
                    ResultViewModel.Data = "";
                }
            }
            return ResultViewModel;
        }
        public static async Task<ResultViewModel> PostAsync<T>(string uri,T entity)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage message = await client.PostAsJsonAsync(uri,entity);

                if (message.IsSuccessStatusCode)
                {
                    ResultViewModel.Result = true;
                    ResultViewModel.Message = "Başarılı bir şekil de kaydedildi.";
                    ResultViewModel.Data = await message.Content.ReadAsStringAsync();
                }
                else
                {
                    ResultViewModel.Result = false;
                    ResultViewModel.Message = await message.Content.ReadAsStringAsync();
                    ResultViewModel.Data = "";
                }
            }
            return ResultViewModel;
        }
        public static async Task<ResultViewModel> DeleteAsync(string uri)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage message = await client.DeleteAsync(uri);

                if (message.IsSuccessStatusCode)
                {
                    ResultViewModel.Result = true;
                    ResultViewModel.Message = "Başarılı bir şekil de silindi.";
                    ResultViewModel.Data = await message.Content.ReadAsStringAsync();
                }
                else
                {
                    ResultViewModel.Result = false;
                    ResultViewModel.Message = await message.Content.ReadAsStringAsync();
                    ResultViewModel.Data = "";
                }
            }
            return ResultViewModel;
        }
        public static async Task<ResultViewModel> UpdateAsync<T>(string uri,T entity)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseAddress);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage message = await client.PutAsJsonAsync(uri,entity);

                if (message.IsSuccessStatusCode)
                {
                    ResultViewModel.Result = true;
                    ResultViewModel.Message = "Başarılı bir şekil de güncellendi.";
                    ResultViewModel.Data = await message.Content.ReadAsStringAsync();
                }
                else
                {
                    ResultViewModel.Result = false;
                    ResultViewModel.Message = await message.Content.ReadAsStringAsync();
                    ResultViewModel.Data = "";
                }
            }
            return ResultViewModel;
        }
    }
}
