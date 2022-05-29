namespace Application.ECDsaAlgorithmProvider;

public class ECDsaAlgorithmProvider : IECDsaAlgorithmProvider
{
    private readonly Func<string?> _ECDsaGetter;
    
    public ECDsaAlgorithmProvider(Func<string?> ECDsaGetter)
    {
        _ECDsaGetter = ECDsaGetter;
    }

    public string? ProvideECDsaAlgorithm()
    {
        return _ECDsaGetter();
    }
}