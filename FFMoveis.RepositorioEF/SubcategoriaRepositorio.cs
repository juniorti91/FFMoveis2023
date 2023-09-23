using FFMoveis.Dominio;
using FFMoveis.Dominio.contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFMoveis.RepositorioEF
{
    public class SubcategoriaRepositorio : IRepositorio<Subcategoria>
    {
        private readonly BD bd;

        public SubcategoriaRepositorio()
        {
            bd = new BD();
        }

        public void Excluir(Subcategoria entidade)
        {
            var subCategoriaExcluir = bd.subcategorias.First(x => x.IdSubcategoria == entidade.IdSubcategoria);
            bd.Set<Subcategoria>().Remove(subCategoriaExcluir);

            bd.SaveChanges();
        }

        public Subcategoria ListarPorId(string id)
        {
            int idint;
            Int32.TryParse(id, out idint);
            return bd.subcategorias.First(x => x.IdSubcategoria == idint);
        }

        public IEnumerable<Subcategoria> ListarTodos()
        {
            return bd.subcategorias;
        }

        public void Salvar(Subcategoria entidade)
        {
            if (entidade.IdSubcategoria > 0) // Alterar caso o ID ja exista
            {
                var subCategoriaAlterar = bd.subcategorias.First(x => x.IdSubcategoria == entidade.IdSubcategoria);
                subCategoriaAlterar.NomeSubcategoria = entidade.NomeSubcategoria;
                subCategoriaAlterar.Categoria = entidade.Categoria;
                //subCategoriaAlterar.IdCategoria = entidade.IdCategoria;
            }
            else // Salvar caso não exista o ID
            {
                bd.subcategorias.Add(entidade);
            }

            bd.SaveChanges();
        }
    }
}
