using MediatR;
using OperationResult;

namespace ViaCepApi_Refit.Domain
{
    public sealed class GetCepRequestHandler : IRequestHandler<GetCepRequest, Result<CepResponse>>
    {
        public Task<Result<CepResponse>> Handle(GetCepRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
