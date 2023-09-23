using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FFMoveis.Dominio
{
    public class Subcategoria
    {
        [Key]
        public int IdSubcategoria { get; set; }

        [Required]
        [StringLength(100)]
        public string NomeSubcategoria { get; set; }

        public int IdCategoria { get; set; }

        [ForeignKey("IdCategoria")]
        public virtual Categoria Categoria { get; set;}

        public virtual ICollection<Produto> Produto { get; set; }
    }
}
