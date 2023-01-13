namespace MangaAPI.Models.DTO.Incoming;

public class LivreForCreationDto
{
    public string nom { get; set; } =string.Empty;
    public string edition { get; set; } =string.Empty;
    public string resumer { get; set; } =string.Empty;
    public double prix { get; set; }
}