using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Security.Cryptography;
using System.Text;

public class Class1
{
    public static string GetRandomPassword()
    {
        int max = 8;

        char[] chars = "1234567890".ToCharArray();
        byte[] data = new byte[1];
        RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
       // crypto.GetNonZeroBytes(data);
        data = new byte[max];
        crypto.GetNonZeroBytes(data);
        StringBuilder result = new StringBuilder(max);
        foreach (byte b in data)
        {
            result.Append(chars[b % (chars.Length - 1)]);
        }
        return result.ToString();

    }



}
