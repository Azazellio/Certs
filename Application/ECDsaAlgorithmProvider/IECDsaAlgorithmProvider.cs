using System.Security.Cryptography;

namespace Application.ECDsaAlgorithmProvider;

public interface IECDsaAlgorithmProvider
{
    public string? ProvideECDsaAlgorithm();
}