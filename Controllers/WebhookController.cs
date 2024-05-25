using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Webohook.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebhookController : ControllerBase
    {
        private readonly ILogger<WebhookController> _logger;

        public WebhookController(ILogger<WebhookController> logger)
        {
            _logger = logger;
        }

        [HttpPost("ParceleDebitos")]
        public RespostaDoProcessamento PostParceleDebitos([FromBody] object requisicao)
        {
            var retorno = new RespostaDoProcessamento();

            if (requisicao == null)
            {
                _logger.LogInformation("A requisi��o est� vazia.");

                retorno.sucesso = true;
                retorno.mensagem = "A requisi��o est� vazia.";
                return retorno; ;
            }

            _logger.LogInformation(requisicao.ToString());

            JObject jsonRequisicao;
            try
            {
                jsonRequisicao = JObject.Parse(requisicao.ToString());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao converter a requisi��o para JSON.");

                retorno.sucesso = true;
                retorno.mensagem = "Erro ao converter a requisi��o para JSON.";
                return retorno;
            }

            if (jsonRequisicao == null)
            {
                _logger.LogInformation("A requisi��o n�o � um JSON v�lido.");

                retorno.sucesso = true;
                retorno.mensagem = "A requisi��o n�o � um JSON v�lido.";
                return retorno;

            }

            // Agora voc� pode manipular o objeto jsonRequisicao conforme necess�rio
            // Por exemplo, para acessar uma propriedade chamada "consulta", voc� pode fazer:
            // int consulta = jsonRequisicao["consulta"]?.ToObject<int>();

            retorno.sucesso = true;
            retorno.mensagem = "Webhook processado com sucesso";
            return retorno;

        }


    }
}
