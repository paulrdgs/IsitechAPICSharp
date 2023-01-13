namespace MangaAPI.Models.DTO.Incoming;

public class UtilisateurForUpdateDto
{
    public string ancien_nom {get; set;} =string.Empty;
    public string ancien_prenom {get; set;} =string.Empty;
    public string nouveau_nom {get; set;} =string.Empty;
    public string nouveau_prenom {get; set;} =string.Empty;
}