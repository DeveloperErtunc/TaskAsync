namespace TaskAsync.Model.Models;
public class Content
{
    public Content(string site, int lenght)
    {
        Site = site;
        Lenght = lenght;
    }
    public string Site { get; set; }
    public int Lenght { get; set; }
}
