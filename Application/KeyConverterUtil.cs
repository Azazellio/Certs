namespace Application;

public static class KeyConverterUtil
{
    public static string ConvertToString(byte[] initial)
    {
        return Convert.ToHexString(initial);
    }

    public static byte[] ConvertToByte(string converted)
    {
        return Convert.FromHexString(converted);
    }
}