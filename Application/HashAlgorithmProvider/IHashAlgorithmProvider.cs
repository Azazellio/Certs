using System.Security.Authentication;

namespace Application;

public interface IHashAlgorithmProvider
{
    public HashAlgorithmType ProvideHashAlgorithm();
}