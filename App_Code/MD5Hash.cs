using System;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Luokat&Metodit MD5Hashin ja SHA256:n tekoon
/// </summary>
namespace JAMK.IT.Security
{
  public static class MD5Hash
  {
    //http://fi.wikipedia.org/wiki/MD5
    public static string GetMd5Hash(string input)
    {
      MD5 md5Hasher = MD5.Create();
      byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
      StringBuilder sBuilder = new StringBuilder();
      for (int i = 0; i < data.Length; i++)
      {
        //X2 prints the string as two uppercase hexadecimal characters...
        //http://msdn.microsoft.com/en-us/library/dwhawy9k%28v=vs.110%29.aspx
        sBuilder.Append(data[i].ToString("x2"));
      }
      return sBuilder.ToString();
    }
    public static bool VerifyMd5Hash(string input, string hash)
    {
      string hashOfInput = GetMd5Hash(input);
      StringComparer comparer = StringComparer.OrdinalIgnoreCase;
      if (0 == comparer.Compare(hashOfInput, hash))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
  public static class SHA256Hash
  {
    //http://fi.wikipedia.org/wiki/SHA
    public static string GetSHA256Hash(string input)
    {
      SHA256 sha256Hasher = SHA256.Create();
      byte[] data = sha256Hasher.ComputeHash(Encoding.Default.GetBytes(input));
      StringBuilder sBuilder = new StringBuilder();
      for (int i = 0; i < data.Length; i++)
      {
        sBuilder.Append(data[i].ToString("x2"));
      }
      return sBuilder.ToString();
    }
    public static string GetSHA256HashV2(string input)
    {
      // Encode the input string into a byte array.
      byte[] inputBytes = Encoding.UTF8.GetBytes(input);
      // Create an instance of the SHA256 algorithm class
      // and use it to calculate the hash.
      SHA256Managed sha256 = new SHA256Managed();
      byte[] outputBytes = sha256.ComputeHash(inputBytes);
      // Convert the outputed hash to a string and return it.
      return Convert.ToBase64String(outputBytes);
    }
    public static bool VerifySHA256Hash(string input, string hash)
    {
      string hashOfInput = GetSHA256Hash(input);
      StringComparer comparer = StringComparer.OrdinalIgnoreCase;
      if (0 == comparer.Compare(hashOfInput, hash))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

  }
  public static class MyConvert
  {
    public static string ConvertStringToHex(string asciiString)
    {
      string hex = "";
      foreach (char c in asciiString)
      {
        int tmp = c;
        hex += String.Format("{0:x2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
      }
      return hex;
    }
  }
}