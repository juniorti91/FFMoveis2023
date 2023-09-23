using FFMoveis.Aplicacao;
using FFMoveis.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FFMoveis.Controllers
{
    public class HomeController : Controller
    {
        private ProdutoAplicacao app_produto;
        private CategoriaAplicacao app_categoria;
        private SubCategoriaAplicacao app_subCategoria;

        public HomeController()
        {
            app_produto = AplicacaoConstrutor.ProdutoEF();
            app_categoria = AplicacaoConstrutor.CategoriaEF();
            app_subCategoria = AplicacaoConstrutor.SubCategoriaEF();
        }

        public ActionResult Index()
        {
            var listarusuario = app_produto.ListarTodos();

            return View();
        }
    }
}