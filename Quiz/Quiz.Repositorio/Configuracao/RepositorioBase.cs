using System.Collections.Generic;
using NHibernate;
using Quiz.Dominio.Repositorio;

namespace Quiz.Repositorio
{
    public abstract class RepositorioBase<T> : IRepositorio<T>
        where T : class
    {
        protected static ISession Session
        { get; private set; }

        public static ITransaction Transacao
        { get { return Session.Transaction; } }

        public RepositorioBase() { }

        public RepositorioBase(ISession session)
        {
            Session = session;
        }

        public ICollection<T> Listar()
        {
            return Session.QueryOver<T>().List();
        }

        public void Salvar(T entidade)
        {
            using (var tran = Session.BeginTransaction())
            {
                Session.SaveOrUpdate(entidade);
                tran.Commit();
            }
        }

        public void Salvar(ICollection<T> entidades)
        {
            using (var tran = Session.BeginTransaction())
            {
                foreach (T e in entidades)
                    Session.SaveOrUpdate(e);
            }
        }

        public void Excluir(T entidade)
        {
            using (var tran = Session.BeginTransaction())
            {
                Session.Delete(entidade);
                tran.Commit();
            }
        }

        public void Excluir(ICollection<T> entidades)
        {
            Transacao.Begin();

            foreach (T e in entidades)
                Session.Delete(e);

            using (var tran = Session.BeginTransaction())
            {
                foreach (T e in entidades)
                    Session.Delete(e);
            }
        }
    }
}
