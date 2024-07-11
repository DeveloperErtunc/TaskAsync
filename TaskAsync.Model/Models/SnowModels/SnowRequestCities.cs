namespace TaskAsync.Model.Models.SnowModels;

public class SnowRequestCities
{
    public SnowRequestCities(string country)
    {
        Country = country;
    }

    public string Country { get; set; }
}
