using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Aplicacao
{
    public interface IAplicacao<T>
        where T : class
    {
        /// <summary>
        /// Lista todos os registros da entidade T
        /// </summary>
        /// <returns>
        /// Lista do tipo T
        /// </returns>
        ICollection<T> Listar();
        /// <summary>
        /// Modifica ou inclui um registro do tipo T na base de dados
        /// </summary>
        /// <param name="entidade">
        /// Objeto do tipo T que será modificado ou incluído na base de dados
        /// </param>
        void Salvar(T entidade);
        /// <summary>
        /// Modifica ou inclui uma lista de registros do tipo T na base de dados
        /// </summary>
        /// <param name="entidade">
        /// Objeto do tipo T que será modificado ou incluído na base de dados
        /// </param>
        void Salvar(ICollection<T> entidades);
        /// <summary>
        /// Elimina um registro do tipo T na base de dados
        /// </summary>
        /// <param name="entidade">
        /// Objeto do tipo T que será eliminado na base de dados
        /// </param>
        void Excluir(T entidade);
        /// <summary>
        /// Elimina um registro do tipo T na base de dados
        /// </summary>
        /// <param name="entidade">
        /// Objeto do tipo T que será eliminado na base de dados
        /// </param>
        void Excluir(ICollection<T> entidades);
    }
}
