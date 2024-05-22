namespace Webohook
{
    public class RequisicaoStatusDaConsulta
    {
        public int id { get; set; }
        public int codigoLote { get; set; }
        public int codigoConsulta { get; set; }
        public string identificacaoConsulta { get; set; }
        public string status { get; set; }
        public string mensagem { get; set; }

        public RequisicaoStatusDaConsulta()
        {
            id = 0;
            codigoLote = 0;
            codigoConsulta = 0;
            identificacaoConsulta = "";
            status = "";
            mensagem = "";
        }

    }
}
