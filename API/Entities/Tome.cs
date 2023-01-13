namespace MangaAPI;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Tome
{

    [Column("idTome")]
    public int id { get; set; }

    [Required]
    public Livre? Livre { get; set; }

    [ForeignKey("Livre")]
    [Required]
    public int idLivre { get; set; } 
     
    [Required]
    public int numtome { get; set; }
}
