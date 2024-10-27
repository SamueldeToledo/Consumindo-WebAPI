using Consumindo_WebAPI.Entities;
using Consumindo_WebAPI.Interface;
using System.Net.Http;
using Newtonsoft.Json;

namespace Consumindo_WebAPI.Repository
{
    public class AdviceRepository : IAdvice
    {
        public async Task<AdviceResponse> AdviceGet()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync("https://api.adviceslip.com/advice");

                    if (response.IsSuccessStatusCode)
                    {
                        var data = await response.Content.ReadAsStringAsync();

                        AdviceResponse JsonObject = JsonConvert.DeserializeObject<AdviceResponse>(data);

                        return JsonObject;
                    }

                        return null;
                    
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
