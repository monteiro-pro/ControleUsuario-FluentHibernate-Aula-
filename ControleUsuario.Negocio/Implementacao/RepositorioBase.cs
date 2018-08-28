using ControleUsuario.Negocio.Repositorio;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleUsuario.Negocio.Implementacao
{
    public class RepositorioBase<T> : ICrudDal<T> where T : class
    {
        public T BuscarId(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entidade)
        {
            throw new NotImplementedException();
        }

        public void Insert(T entidade)
        {
            // Abrir Uma Sessão
            using (ISession _session = NHibernateConecao.AbrirConexao())
            {
                // Abrir a Transação
                using (ITransaction _trasaction = _session.BeginTransaction())
                {
                    try
                    {
                        // Salvar em Sessão
                        _session.Save(entidade);
                        // Banco
                        _trasaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!_trasaction.WasCommitted)
                            _trasaction.Rollback();
                        throw new Exception("Erro ao Salvar: " + ex.Message);
                    }
                }
            }
        }

        public List<T> Listar()
        {
            throw new NotImplementedException();
        }

        public void Update(T endidade)
        {
            throw new NotImplementedException();
        }
    }
}
