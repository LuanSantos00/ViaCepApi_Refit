using FluentValidation;

namespace ViaCepApi_Refit.Domain
{
    public sealed class GetCepRequestValidator : AbstractValidator<GetCepRequest>
    {
        public GetCepRequestValidator()
            => RuleFor(cepRequest => cepRequest.Cep)
                .NotEmpty()
                .NotNull();
    }
}
