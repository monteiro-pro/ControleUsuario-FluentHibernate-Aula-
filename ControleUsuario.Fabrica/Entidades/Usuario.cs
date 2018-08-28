using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleUsuario.Fabrica.Entidades
{
    public class Usuario
    {
        public virtual int id { get; set; }
        public virtual string email { get; set; }
        public virtual string senha { get; set; }
        public virtual string nome { get; set; }
        public virtual IList<Permissao> permissoes { get; set; }

        public Usuario()
        {
            permissoes = new List<Permissao>();
        }
    }
}
