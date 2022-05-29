namespace Domain;

public interface IBlockPayload
{
    public string CalculateHash();
    public string ToView();
    public string ToPreview();
}