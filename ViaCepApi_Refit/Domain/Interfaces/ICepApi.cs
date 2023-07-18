using Refit;

namespace ViaCepApi_Refit.Domain
{
    public interface ICepApi
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressAsync(string cep);
    }
}
