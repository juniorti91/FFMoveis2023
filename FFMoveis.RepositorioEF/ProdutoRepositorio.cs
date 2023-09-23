using FFMoveis.Dominio;
using FFMoveis.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFMoveis.RepositorioEF
{
    public class ProdutoRepositorio : IRepositorio<Produto>
    {
        private readonly BD bd;

        public ProdutoRepositorio()
        {
            bd = new BD();
        }

        public void Excluir(Produto entidade)
        {
            var produtoExcluir = bd.produtos.First(x => x.IdProduto == entidade.IdProduto);
            bd.Set<Produto>().Remove(produtoExcluir);

            bd.SaveChanges();
        }

        public Produto ListarPorId(string id)
        {
            int idint;
            Int32.TryParse(id, out idint); 
            return bd.produtos.First(x => x.IdProduto == idint);
        }

        public IEnumerable<Produto> ListarTodos()
        {
            return bd.produtos;
        }

        public void Salvar(Produto entidade)
        {
            if (entidade.IdProduto > 0) // Alterar caso o ID ja exista
            {
                var produtoAlterar = bd.produtos.First(x => x.IdProduto == entidade.IdProduto);
                produtoAlterar.NomeProduto = entidade.NomeProduto;
                produtoAlterar.DescricaoProduto = entidade.DescricaoProduto;
                produtoAlterar.PrecoProduto = entidade.PrecoProduto;
            }
            else // Salvar caso não exista o ID
            {
                bd.produtos.Add(entidade);
            }

            bd.SaveChanges();
        }
    }
}
