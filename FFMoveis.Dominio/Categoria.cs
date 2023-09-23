using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FFMoveis.Dominio
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        [Required]
        [StringLength(100)]
        public string NomeCategoria { get; set; }

        public virtual ICollection<Subcategoria> Subcategorias { get; set;}
    }
}
