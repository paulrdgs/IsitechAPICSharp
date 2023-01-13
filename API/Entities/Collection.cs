using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MangaAPI;

public class Collection
{
        [Column("idCollection")]
        public int id { get; set; }

        [Required]
        public Utilisateur? Utilisateur { get; set; }
        
        [ForeignKey("Utilisateur")]
        [Required]
        public int idUtilisateur { get; set; }

        [Required]
        public Livre? Livre { get; set; }
        
        [ForeignKey("Livre")]
        [Required]
        public int idLivre { get; set; }

        [Required]
        public Tome? Tome { get; set; }
        
        [ForeignKey("Tome")]
        [Required]
        public int idTome { get; set; }
}
