using TaskAsync.Model.Models.SnowModels;

namespace TaskAsync.Service.IServices;

public interface ISnowService
{
    Task<string> GetCities(string country);
    Task ContinueWithCities(Task<SnowResponseModel> snowResultTask, int? count = null);
    Task<SnowResponseModel> GetCitiesSnowResponse(string country);
}
