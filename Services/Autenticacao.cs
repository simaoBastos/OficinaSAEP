using System.Security.Cryptography;

namespace OficinaSAEP.Services;

internal class Autenticacao
{
    public static bool VerificarSenha(string senhaArmazenada, string senhaFornecida)
    {
        var partes = senhaArmazenada.Split(':');
        if (partes.Length != 3)
        {
            throw new FormatException("Formato de senha armazenada inválido.");
        }
        int iteracoes = int.Parse(partes[0]);
        byte[] salt = Convert.FromBase64String(partes[1].Trim());
        byte[] hashArmazenado = Convert.FromBase64String(partes[2].Trim());
        byte[] hashFornecido = Rfc2898DeriveBytes.Pbkdf2(senhaFornecida, salt, iteracoes, HashAlgorithmName.SHA256, hashArmazenado.Length);
        return CryptographicOperations.FixedTimeEquals(hashArmazenado, hashFornecido);
    }
}
