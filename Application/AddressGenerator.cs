using System.Security.Cryptography;

namespace Application;

public class AddressGenerator
{
    
    public static (byte[], byte[]) GetBothKeys(ECDsa ec)
    {
        //var ec = ECDsa.Create();
        //var curve = ECCurve.CreateFromOid(Oid.FromFriendlyName("secP256r1", OidGroup.SignatureAlgorithm));
        //ec.GenerateKey(curve);
        var privkey = ec.ExportECPrivateKey();
        var pubKey = ec.ExportSubjectPublicKeyInfo();
        return (privkey, pubKey);
    }

    public static byte[] GetPrivateKey(ECDsa ec)
    {
        try
        {
            return ec.ExportECPrivateKey();
        }
        catch(CryptographicException e)
        {
            throw;
        }
    }
    
    public static byte[] GetPublicKey(ECDsa ec)
    {
        try
        {
            return ec.ExportSubjectPublicKeyInfo();
        }
        catch (CryptographicException e)
        {
            throw;
        }
    }
}