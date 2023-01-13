namespace MangaAPI.Models.DTO.Incoming;

public class LivreForUpdateDto
{
    public string NomDuLivre {get; set;} =string.Empty;
    public string nouveau_resumer {get; set;} =string.Empty;
    public double nouveau_prix {get; set;}
}