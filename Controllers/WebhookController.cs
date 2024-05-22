using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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

        [HttpPost("StatusDaConsulta")]
        public RespostaStatusDaConsulta Post(RequisicaoStatusDaConsulta requisicao)
        {
            var retorno = new RespostaStatusDaConsulta();

            _logger.LogInformation(JsonConvert.SerializeObject(requisicao));

            retorno.sucesso = true;
            retorno.mensagem = "Webhook processado com sucesso";
            return retorno;
        }

    }
}
