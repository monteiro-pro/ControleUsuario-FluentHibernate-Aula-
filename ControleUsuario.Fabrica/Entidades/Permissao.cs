using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleUsuario.Fabrica.Entidades
{
    public class Permissao
    {
        public virtual int id { get; set; }
        public virtual string nome { get; set; }
        public virtual IList<Usuario> usuarios { get; set; }

        public Permissao()
        {
            usuarios = new List<Usuario>();
        }
    }
}
