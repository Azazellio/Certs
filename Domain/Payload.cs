using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;

namespace Domain;

public class Payload : IBlockPayload
{
    private byte[] data;
    private string owner;
    private string target;
    private long timeCreated;

    public Payload(byte[] data, string owner, string target)
    {
        this.data = data;
        this.owner = owner;
        this.target = target;
        timeCreated = DateTime.Now.Ticks;
        
    }

    public byte[] CalculateHash(HashAlgorithmType algorithm = HashAlgorithmType.Sha256)
    {
        var hashProvider = HashAlgorithm.Create(algorithm.ToString());
        // byte[] hashedData = hashProvider.ComputeHash(Encoding.UTF8.GetBytes(ToView()));
        byte[] hashedData = hashProvider.ComputeHash(PrepareBlockToHash().ToArray());

        // Create a new Stringbuilder to collect the bytes
        // and create a string.
        // var sBuilder = new StringBuilder();
        //
        // // Loop through each byte of the hashed data
        // // and format each one as a hexadecimal string.
        // for (int i = 0; i < hashedData.Length; i++)
        // {
        //     sBuilder.Append(hashedData[i].ToString("x2"));
        // }
        // Return the hexadecimal string.
        // return sBuilder.ToString();
        return hashedData;
    }

    public IEnumerable<byte> PrepareBlockToHash()
    {
        List<byte> res = data.ToList();
        //res.AddRange(Encoding.UTF8.GetBytes(this.owner));
        //res.AddRange(Encoding.UTF8.GetBytes(this.target));
        //res.AddRange(Encoding.UTF8.GetBytes(timeCreated.ToString())); 
        res.AddRange(data);
        return res;
    }

    public string CalculateHash()
    {
        throw new NotImplementedException();
    }

    public string ToView()
    {
        StringBuilder res = new StringBuilder();
        //res.Append(Encoding.UTF8.GetString(this.data));
        res.Append(this.owner);
        res.Append(this.target);
        res.Append(DateTime.Now);
        return res.ToString();
    }

    public string ToPreview()
    {
        throw new NotImplementedException();
    }
}