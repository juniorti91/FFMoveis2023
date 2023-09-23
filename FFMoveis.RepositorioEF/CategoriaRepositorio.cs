using FFMoveis.Dominio;
using FFMoveis.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FFMoveis.RepositorioEF
{
    public class CategoriaRepositorio : IRepositorio<Categoria>
    {
        private readonly BD bd;

        public CategoriaRepositorio()
        {
            bd = new BD();
        }

        public void Excluir(Categoria entidade)
        {
            var categoriaExcluir = bd.categoria.First(x => x.IdCategoria == entidade.IdCategoria);
            bd.Set<Categoria>().Remove(categoriaExcluir);

            bd.SaveChanges();
        }

        public Categoria ListarPorId(string id)
        {
            int idint;
            Int32.TryParse(id, out idint);
            return bd.categoria.First(x => x.IdCategoria == idint);
        }

        public IEnumerable<Categoria> ListarTodos()
        {
            return bd.categoria;
        }

        public void Salvar(Categoria entidade)
        {
            if (entidade.IdCategoria > 0) // Alterar caso o ID ja exista
            {
                var categoriaAlterar = bd.categoria.First(x => x.IdCategoria == entidade.IdCategoria);
                categoriaAlterar.NomeCategoria = entidade.NomeCategoria;
                categoriaAlterar.Subcategorias = entidade.Subcategorias;
            }
            else // Salvar caso não exista o ID
            {
                bd.categoria.Add(entidade);
            }

            bd.SaveChanges();
        }
    }
}
