namespace FisioEscala.Domain.Services
{
    public static class CryptoService
    {
        public static string Reverse(string key)
        {
            return new String(key.Reverse().ToArray());
        }
    }
}
