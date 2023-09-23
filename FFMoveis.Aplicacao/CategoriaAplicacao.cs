using FFMoveis.Dominio;
using FFMoveis.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFMoveis.Aplicacao
{
    public class CategoriaAplicacao
    {
        private readonly IRepositorio<Categoria> repo_categoria;

        public CategoriaAplicacao(IRepositorio<Categoria> repo)
        {
            repo_categoria = repo;
        }

        public void Salvar(Categoria categoria)
        {
            repo_categoria.Salvar(categoria);
        }

        public void Excluir(Categoria categoria)
        {
            repo_categoria.Excluir(categoria);
        }

        public IEnumerable<Categoria> ListarTodos()
        {
            return repo_categoria.ListarTodos();
        }

        public Categoria ListarPorId(string id)
        {
            return repo_categoria.ListarPorId(id);
        }
    }
}
