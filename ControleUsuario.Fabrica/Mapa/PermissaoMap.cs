using ControleUsuario.Fabrica.Entidades;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleUsuario.Fabrica.Mapa
{
    public class PermissaoMap: ClassMap<Permissao>
    {
        public PermissaoMap()
        {
            Table("tblPermissao"); // Para Nomear a Tabela
            Id(p => p.id).GeneratedBy.Increment(); // Mapeando o Indentificador da Tabela, AutoImplementavel
            Map(p => p.nome).Not.Nullable();
            /* Tipo de Relações entre Entidade: 
              1x1 = References()
              1xn = HasMany()
              nxn = HasManyToMany()
           */
            HasManyToMany(p => p.usuarios)
                .Table("tblUsuarioPermissoes")
                .ParentKeyColumn("usuarioId")
                .ChildKeyColumn("permissaoId")
                .LazyLoad(); /* Por default é true. Carrega na memória apenas a tabela Pai da referencia de tabelas, caso necessário, carrega as dependecias. Se alterado .Not.LazyLoad(),
                               carrega todas as tabelas da depencia. */
        }
    }
}
