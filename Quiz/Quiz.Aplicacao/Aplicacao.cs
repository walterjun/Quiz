using Quiz.Aplicacao.Servicos;

namespace Quiz.Aplicacao
{
    /// <summary>
    /// Lista dos serviços disponíveis de acesso à base
    /// </summary>
    public class Aplicacao
    {
        public static TipoContaServico TipoConta()
        { return new TipoContaServico(); }

        public static ContaServico Conta()
        { return new ContaServico(); }
    }
}
