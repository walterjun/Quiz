using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Quiz.Dominio.Entidade;
using Quiz.Dominio.Repositorio;

namespace Quiz.Repositorio
{
    public sealed class TipoContaRepositorio : ITipoContaRepositorio
    {
        private readonly ISession _session;

        public TipoContaRepositorio(ISession session)
        {
            _session = session;
        }

        public ICollection<TipoConta> Listar()
        {
            throw new NotImplementedException();
        }

        public void Salvar(TipoConta entidade)
        {
            throw new NotImplementedException();
        }

        public void Salvar(ICollection<TipoConta> entidades)
        {
            throw new NotImplementedException();
        }

        public void Excluir(TipoConta entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(ICollection<TipoConta> entidades)
        {
            throw new NotImplementedException();
        }
    }
}
