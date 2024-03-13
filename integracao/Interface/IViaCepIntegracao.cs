using ViaCep.integracao.Response;

namespace ViaCep.integracao.Interface
{
    public interface IViaCepIntegracao
    {
        Task<ViaCepResponse> ObterDadosViaCep(string cep);

    }
}
