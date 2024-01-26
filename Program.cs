using System;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string message = "สวัสดีชาวโลก";
        byte[] hashValue;

        using (HashAlgorithm hash = SHA256.Create())
        {
            hashValue = hash.ComputeHash(Encoding.UTF8.GetBytes(message));
        }

        Console.WriteLine("ข้อความเข้ารหัส: ");
        foreach (byte b in hashValue)
        {
            Console.Write($"{b:x2}");
        }
    }
}
