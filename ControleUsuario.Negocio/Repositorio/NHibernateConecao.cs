using ControleUsuario.Fabrica.Mapa;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleUsuario.Negocio.Repositorio
{
    public class NHibernateConecao
    {
        private static ISessionFactory session;
        private static ISessionFactory CriarSessao()
        {
            if (session != null)
                return session;

            //Configurar a Conexão
            FluentConfiguration _configuration = Fluently.Configure()
                                                        .Database(
                                                            MySQLConfiguration.Standard.ConnectionString(x => x.Server
                                                                                                                ("localhost")
                                                                                                                .Username("root")
                                                                                                                .Password("")
                                                                                                                .Database("bdusuario")))
                                                            .Mappings(
                                                                    c => c.FluentMappings.AddFromAssemblyOf<UsuarioMapa>())
                                                                    .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true));
            session = _configuration.BuildSessionFactory();
            return session;
        }

        public static ISession AbrirConexao()
        {
            return CriarSessao().OpenSession();
        }
    }
}
