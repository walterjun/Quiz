using System;
using System.Collections.Generic;
using Quiz.Dominio.Entidade;
using Quiz.Dominio.Repositorio;
using Quiz.Repositorio;

namespace Quiz.Aplicacao.Servicos
{
    public class ContaServico : IAplicacao<Contas>
    {
        IContaRepositorio Repositorio;

        internal ContaServico()
        {
            Repositorio = new ContaRepositorio();
        }

        public ICollection<Contas> Listar()
        {
            return Repositorio.Listar();
        }

        public void Salvar(Contas entidade)
        {
            Repositorio.Salvar(entidade);
        }

        public void Salvar(ICollection<Contas> entidades)
        {
            Repositorio.Salvar(entidades);
        }

        public void Excluir(Contas entidade)
        {
            Repositorio.Excluir(entidade);
        }

        public void Excluir(ICollection<Contas> entidades)
        {
            Repositorio.Excluir(entidades);
        }
    }
}
