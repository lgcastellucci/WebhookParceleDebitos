namespace Webohook
{
    public class RespostaDoProcessamento
    {
        public bool sucesso { get; set; }
        public string mensagem { get; set; }
        public DateTime dataAtual { get; set; }
        public RespostaDoProcessamento()
        {
            sucesso = false;
            mensagem = "Erro ao atualizar status da consulta";
            dataAtual = DateTime.Now;
        }

    }
}
