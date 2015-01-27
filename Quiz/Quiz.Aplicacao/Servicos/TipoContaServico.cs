using System.Collections.Generic;
using Quiz.Dominio.Entidade;
using Quiz.Dominio.Repositorio;
using Quiz.Repositorio;
using StructureMap;

namespace Quiz.Aplicacao.Servicos
{
    public class TipoContaServico : IAplicacao<TipoConta>
    {
        ITipoContaRepositorio Repositorio;

        internal TipoContaServico()
        {
            Repositorio = ObjectFactory.GetInstance<ITipoContaRepositorio>();
        }

        public ICollection<TipoConta> Listar()
        {
            return Repositorio.Listar();
        }

        public void Salvar(TipoConta entidade)
        {
            Repositorio.Salvar(entidade);
        }

        public void Salvar(ICollection<TipoConta> entidades)
        {
            Repositorio.Salvar(entidades);
        }

        public void Excluir(TipoConta entidade)
        {
            Repositorio.Excluir(entidade);
        }

        public void Excluir(ICollection<TipoConta> entidades)
        {
            Repositorio.Excluir(entidades);
        }
    }
}
