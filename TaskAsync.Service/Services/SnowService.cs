using TaskAsync.Model.Models.SnowModels;

namespace TaskAsync.Service.Services;

public class SnowService : ISnowService
{
    readonly HttpClient _httpClient;
    public SnowService(IHttpClientFactory factory)
    {
        _httpClient = factory.CreateClient(StringConstants.CountriesSnow);
    }

    public async Task<string> GetCities(string country)
    {
        var postModel = new  SnowRequestCities(country);
        var responseTask =await _httpClient.PostAsJsonAsync("countries/cities", postModel);
        var result = await responseTask.Content.ReadFromJsonAsync<SnowResponseModel>();
        return !result.Error ? string.Join(",", result.Data) : result.Msg;
    }
    public async Task<SnowResponseModel> GetCitiesSnowResponse(string country)
    {
        var postModel = new SnowRequestCities(country);
        var responseTask =await _httpClient.PostAsJsonAsync("countries/cities", postModel);
        return await responseTask.Content.ReadFromJsonAsync<SnowResponseModel>();
    }
    public async Task ContinueWithCities(Task<SnowResponseModel> snowResultTask, int? count =null)
    {
       var  snowResult =await snowResultTask;
        if(snowResult.Error == false)
        {
            if (count != null)
            {
                snowResult.Data = snowResult.Data.Take(count.Value).ToList();
            }
            Console.WriteLine(string.Join(",", snowResult.Data));
        }
        Console.WriteLine(snowResult.Msg);
    }
}
