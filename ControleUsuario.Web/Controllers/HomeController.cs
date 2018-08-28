using ControleUsuario.Fabrica.Entidades;
using ControleUsuario.Negocio.Implementacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleUsuario.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UsuarioRepositorio re = new UsuarioRepositorio();

            PermissaoRepositorio re2 = new PermissaoRepositorio();

            List<Permissao> perlist = new List<Permissao>();

            Permissao per = new Permissao
            {
                nome = "Administrador"
            };

            perlist.Add(per);

            Usuario usu = new Usuario
            {
                nome = "Mont",
                email = "teste",
                senha = "123",
                permissoes = perlist

            };

            re.Insert(usu);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}