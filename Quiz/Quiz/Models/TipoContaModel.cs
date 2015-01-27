using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quiz.Models.Home
{
    public class TipoContaModel
    {
        public ICollection<Quiz.Dominio.Entidade.TipoConta> tipoConta { get; set; }
    }
}