using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Quiz.Dominio.Entidade;

namespace Quiz.Repositorio.Mapeamentos
{
    public class ContasMap : ClassMap<Contas>
    {
        public ContasMap()
        {
            Id(x => x.Id)
                .GeneratedBy.Native()
                .UnsavedValue(0).Column("ID_CONTAS");
            Map(x => x.Senha).Column("DSC_SENHA");
            Map(x => x.DatAlteracao).Column("DAT_ALTERACAO");
            Map(x => x.DatCadastro).Column("DAT_CADASTRO");
            Map(x => x.Email).Column("DSC_EMAIL");
            References<TipoConta>(x => x.TipoConta).Column("T_TIPOS_CONTA_ID_TIPO_CONTA");
        }
    }
}
