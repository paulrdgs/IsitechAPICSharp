using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MangaAPI;

public class Livre
{
    [Column("idLivre")]
    public int id { get; set; }

    [Required]
    public string nom { get; set; } =string.Empty;

    [Required]
    public string edition { get; set; } =string.Empty;

    [Required]
    public string resumer { get; set; } =string.Empty;

    [Required]
    public double prix { get; set; }
}