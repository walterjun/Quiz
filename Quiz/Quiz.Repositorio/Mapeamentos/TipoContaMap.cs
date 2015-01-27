using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Quiz.Dominio.Entidade;

namespace Quiz.Repositorio.Mapeamentos
{
    public class TipoContaMap : ClassMap<TipoConta>
    {
        public TipoContaMap()
        {
            Id(x => x.Id)
                .GeneratedBy.Native()
                .UnsavedValue(0).Column("ID_TIPO_CONTA");
            Map(x => x.dscNome).Column("DSC_NOME");
        }
    }
}
