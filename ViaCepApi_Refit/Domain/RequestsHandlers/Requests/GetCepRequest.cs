using MediatR;
using OperationResult;

namespace ViaCepApi_Refit.Domain
{
    public sealed class GetCepRequest : IRequest<Result<CepResponse>>
    {
        public string Cep { get; set; }
    }
}
