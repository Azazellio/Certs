using System.Security.Cryptography;

namespace Application.ECDsaProvider;

public interface IECDsaProvider
{
    public ECDsa GetECDsa();
}