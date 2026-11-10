using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OficinaSAEP.Services;

internal class Criptografia
{
    private static readonly byte[] chave = Encoding.UTF8.GetBytes("OficinaSAEP2026Key12345678901234");
    private static readonly byte[] iv = Encoding.UTF8.GetBytes("OficinaSAEP2026!");
    public static string Criptografar(string texto)
    {
        using var aes = Aes.Create();
        aes.Key = chave;
        aes.IV = iv;
        using ICryptoTransform encryptor = aes.CreateEncryptor();
        byte[] textoBytes = Encoding.UTF8.GetBytes(texto);
        byte[] textoCriptografado = encryptor.TransformFinalBlock(textoBytes, 0, textoBytes.Length);
        return Convert.ToBase64String(textoCriptografado);
    }
    public static string Descriptografar(string textoCriptografado)
    {
        using var aes = Aes.Create();
        aes.Key = chave;
        aes.IV = iv;
        using ICryptoTransform decryptor = aes.CreateDecryptor();
        byte[] textoCriptografadoBytes = Convert.FromBase64String(textoCriptografado);
        byte[] textoDescriptografadoBytes = decryptor.TransformFinalBlock(textoCriptografadoBytes, 0, textoCriptografadoBytes.Length);
        return Encoding.UTF8.GetString(textoDescriptografadoBytes);
    }
}
