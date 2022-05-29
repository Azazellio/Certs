using System.Security.Authentication;

namespace Application;

public class HashAlgorithmProvider : IHashAlgorithmProvider
{
    private readonly Func<HashAlgorithmType> _typeGetter;

    public HashAlgorithmProvider(Func<HashAlgorithmType> typeGetter)
    {
        _typeGetter = typeGetter;
    }
    
    public HashAlgorithmType ProvideHashAlgorithm()
    {
        return _typeGetter();
    }
}