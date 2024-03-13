using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ViaCep.integracao.Interface;
using ViaCep.integracao.Response;

namespace ViaCep.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CepController : ControllerBase
    {
        private readonly IViaCepIntegracao _viaCepIntegracao;

        public CepController(IViaCepIntegracao viaCepIntegracao)
        {
            _viaCepIntegracao = viaCepIntegracao;   

        }


        [HttpGet("{cep}")]
        public async Task<ActionResult<ViaCepResponse>> ListarDadosEndereco(string cep)
        {
         var responseData = await _viaCepIntegracao.ObterDadosViaCep(cep);    

        if(responseData == null) {
                return BadRequest("Cep Não Encontrado");
        }

        return Ok(responseData);    
        }
    }
}
