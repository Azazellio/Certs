using System.Security.Cryptography;
using Application.ECDsaAlgorithmProvider;

namespace Application.ECDsaProvider;

public class ECDsaProvider : IECDsaProvider
{
    private readonly ECDsa _ecDsa;
    public ECDsaProvider(IECDsaAlgorithmProvider algorithmProvider)
    {
        var algorithm = algorithmProvider.ProvideECDsaAlgorithm();
        _ecDsa = algorithm == null ? ECDsa.Create() : ECDsa.Create(algorithm);
    }
    public ECDsa GetECDsa()
    {
        return _ecDsa;
    }
}