namespace ViaCepApi_Refit.Infra.Exceptions
{
    public sealed class CepAddressNotFoundException : Exception
    {
        public CepAddressNotFoundException()
           : base("Cep Address not found") { }
    }
}
