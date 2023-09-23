using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FFMoveis.Dominio
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }

        [Required]
        [StringLength(100)]
        public string NomeProduto { get; set; }

        [StringLength(255)]
        public string DescricaoProduto { get; set; }
        public decimal PrecoProduto { get; set; }
        public int IdSubcategoria { get; set; }

        [ForeignKey("IdSubcategoria")]
        public virtual Subcategoria Subcategoria { get; set; }        
    }
}
