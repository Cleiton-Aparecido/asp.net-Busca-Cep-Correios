using Refit;
using ViaCep.integracao.Response;

namespace ViaCep.integracao.Refit
{
    public interface IViaCepIntegracaoRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<ViaCepResponse>> ObterDadosViaCep(string cep);

    }
}
