using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Dominio.Entidade
{
    public class Contas
    {
        public virtual int Id { get; set; }
        public virtual string Senha { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime DatCadastro { get; set; }
        public virtual DateTime DatAlteracao { get; set; }
        
        public virtual TipoConta TipoConta { get; set; }
    }
}
