using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleUsuario.Negocio.Repositorio
{
    public interface ICrudDal<T>
    {
        void Insert(T entidade);
        void Update(T endidade);
        void Delete(T entidade);
        T BuscarId(int id);
        List<T> Listar();
    }
}
