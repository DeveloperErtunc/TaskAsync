namespace TaskAsync.Model.Models.SnowModels;

public class SnowResponseModel
{
    public bool Error { get; set; }
    public string? Msg { get; set; }
    public List<string>? Data { get; set; }
}