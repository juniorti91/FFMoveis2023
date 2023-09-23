using FFMoveis.Aplicacao;
using FFMoveis.RepositorioEF;

namespace FFMoveis.Dominio
{
    public class AplicacaoConstrutor
    {
        public static CategoriaAplicacao CategoriaEF() 
        {
            CategoriaRepositorio categoriaRepositorio = new CategoriaRepositorio();
            return new CategoriaAplicacao(categoriaRepositorio);
        }

        public static SubCategoriaAplicacao SubCategoriaEF() 
        {
            SubcategoriaRepositorio subcategoriaRepositorio = new SubcategoriaRepositorio();
            return new SubCategoriaAplicacao(subcategoriaRepositorio);
        }

        public static ProdutoAplicacao ProdutoEF() 
        {
            ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();
            return new ProdutoAplicacao(produtoRepositorio);
        }
    }
}
