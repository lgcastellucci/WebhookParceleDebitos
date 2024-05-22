namespace Webohook
{
    public class RespostaStatusDaConsulta
    {
        public bool sucesso { get; set; }
        public string mensagem { get; set; }
        public DateTime dataAtual { get; set; }
        public RespostaStatusDaConsulta()
        {
            sucesso = false;
            mensagem = "Erro ao atualizar status da consulta";
            dataAtual = DateTime.Now;
        }

    }
}
