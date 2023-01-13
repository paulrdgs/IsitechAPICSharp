using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MangaAPI;

public class Utilisateur
{
    [Column("idUtilisateur")]
    public int id { get; set; }

    [Required]
    public string nom { get; set; } =string.Empty;

    [Required]
    public string prenom { get; set; } =string.Empty;
}