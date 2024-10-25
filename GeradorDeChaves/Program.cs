using GeradorDeChaves;
using System;
using System.Security.Cryptography;

byte[] aesKey = Chaves.GenerateAESKey(32); // 32 bytes = 256 bits

// Exibe a chave em formato hexadecimal, alternando entre uppercase e lowercase
string formattedKey = Chaves.ConvertToAlternatingHex(aesKey);
Console.WriteLine("Chave AES de 32 bytes (alternando uppercase e lowercase para exibição):");
Console.WriteLine(formattedKey);

// Exemplo de uso com AES, usando a chave como array de bytes
using (Aes aesAlg = Aes.Create())
{
    aesAlg.Key = aesKey; // Usa a chave de 32 bytes diretamente
    aesAlg.GenerateIV(); // Gera um vetor de inicialização (IV)

    // Exibe a IV em formato hexadecimal
    string formattedIV = Chaves.ConvertToAlternatingHex(aesAlg.IV);
    Console.WriteLine("IV de 16 bytes (alternando uppercase e lowercase para exibição):");
    Console.WriteLine(formattedIV);

    Console.WriteLine("AES Key Length: " + aesAlg.Key.Length); // Deve ser 32 bytes para AES-256
    Console.WriteLine("IV Length: " + aesAlg.IV.Length);       // Deve ser 16 bytes}
}

//Chave AES de 32 bytes (alternando uppercase e lowercase para exibição):
//6647A2f7D4256Fd65Def9A36772d14401E5092f7A7db4C4fFC11850e99da81cd
//IV de 16 bytes (alternando uppercase e lowercase para exibição):
//B85938ebDAb41F287B38C83228c44528
//AES Key Length: 32
//IV Length: 16