using FFMoveis.Dominio;
using FFMoveis.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFMoveis.Aplicacao
{
    public class ProdutoAplicacao
    {
        private readonly IRepositorio<Produto> repo_produto;

        public ProdutoAplicacao(IRepositorio<Produto> repo)
        {
            repo_produto = repo;
        }

        public void Salvar (Produto produto)
        {
            repo_produto.Salvar(produto);
        }

        public void Excluir(Produto produto)
        {
            repo_produto.Excluir(produto);
        }

        public IEnumerable<Produto> ListarTodos()
        {
            return repo_produto.ListarTodos();
        }

        public Produto ListarPorId(string id)
        {
            return repo_produto.ListarPorId(id);
        }
    }
}
