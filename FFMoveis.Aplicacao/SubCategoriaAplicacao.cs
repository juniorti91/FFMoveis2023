using FFMoveis.Dominio;
using FFMoveis.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFMoveis.Aplicacao
{
    public class SubCategoriaAplicacao
    {
        private readonly IRepositorio<Subcategoria> repo_subcategoria;

        public SubCategoriaAplicacao(IRepositorio<Subcategoria> repo)
        {
            repo_subcategoria = repo;
        }

        public void Salvar(Subcategoria subcategoria)
        {
            repo_subcategoria.Salvar(subcategoria);
        }

        public void Excluir(Subcategoria subcategoria)
        {
            repo_subcategoria.Excluir(subcategoria);
        }

        public IEnumerable<Subcategoria> ListarTodos()
        {
            return repo_subcategoria.ListarTodos();
        }

        public Subcategoria ListarPorId(string id)
        {
            return repo_subcategoria.ListarPorId(id);
        }
    }
}
