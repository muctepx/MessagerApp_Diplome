using System.Security.Cryptography;

namespace UserService.Security
{
    public static class RSATools
    {
        public static RSA GetPrivateKey(IConfiguration configuration)
        {
            var privateKeyPem = configuration["Keys:PrivateKey"];
            Console.WriteLine($"Public Key: {privateKeyPem}");
            var rsa = RSA.Create();
            rsa.ImportFromPem(privateKeyPem);
            return rsa;
        }

        public static RSA GetPublicKey(IConfiguration configuration)
        {
            var publicKeyPem = configuration["Keys:PublicKey"];
            Console.WriteLine($"Public Key: {publicKeyPem}");
            var rsa = RSA.Create();
            rsa.ImportFromPem(publicKeyPem);
            return rsa;
        }
    }
}
