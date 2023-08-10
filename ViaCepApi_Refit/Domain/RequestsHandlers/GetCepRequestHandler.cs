using MediatR;
using OperationResult;
using ViaCepApi_Refit.Infra.Exceptions;

namespace ViaCepApi_Refit.Domain
{
    public sealed class GetCepRequestHandler : IRequestHandler<GetCepRequest, Result<CepResponse>>
    {
        private readonly ICepApi _cepApi;

        public GetCepRequestHandler(ICepApi cepApi)
            => _cepApi = cepApi;

        public async Task<Result<CepResponse>> Handle(GetCepRequest request, CancellationToken cancellationToken)
        {
            var response = await _cepApi.GetAddressAsync(request.Cep);

            if (response is null)
                return new CepAddressNotFoundException();

            return Result.Success(response);
        }
    }
}
