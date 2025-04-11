using System;
using System.Security.Cryptography;

class ExportBase64Keys
{
    static void Main()
    {
        using RSA rsa = RSA.Create(4096);
        string publicKey = Convert.ToBase64String(rsa.ExportRSAPublicKey());
        string privateKey = Convert.ToBase64String(rsa.ExportRSAPrivateKey());

        Console.WriteLine("Public Key:\n" + publicKey);
        Console.WriteLine("\nPrivate Key:\n" + privateKey);
    }
}
