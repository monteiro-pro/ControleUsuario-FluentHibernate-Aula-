using ControleUsuario.Fabrica.Entidades;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleUsuario.Fabrica.Mapa
{
    public class UsuarioMapa: ClassMap<Usuario>
    {
        public UsuarioMapa()
        {
            Table("tblUsuario"); // Para Nomear a Tabela
            Id(u => u.id).GeneratedBy.Identity(); // Mapeando o Indentificador da Tabela, AutoImplementavel
            Map(u => u.email).Unique().Not.Nullable();
            Map(u => u.senha).Not.Nullable();
            Map(u => u.nome).Not.Nullable();
            /* Tipo de Relações entre Entidade: 
               1x1 = References()
               1xn = HasMany()
               nxn = HasManyToMany()
            */
            HasManyToMany(u => u.permissoes)
                .Table("tblUsuarioPermissoes")
                .ParentKeyColumn("permissaoId")
                .ChildKeyColumn("usuarioId")
                .LazyLoad() /* Por default é true. Carrega na memória apenas a tabela Pai da referencia de tabelas, caso necessário, carrega as dependecias. Se alterado .Not.LazyLoad(),
                               carrega todas as tabelas da depencia. */
                .Cascade.SaveUpdate(); /* Quando o objeto é salvo/atualizado, verifique as associações e salva/atualiza qualquer objeto que o exija. */
        }
    }
}
