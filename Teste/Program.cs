using ControleUsuario.Fabrica.Entidades;
using ControleUsuario.Negocio.Implementacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}
