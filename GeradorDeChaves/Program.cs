using GeradorDeChaves;

byte[] aesKey16 = Chaves.GenerateAESKey(16); // 16 bytes = 128 bits, necessário para AES-128

// Converte a chave para hexadecimal com intercalamento de uppercase e lowercase
string formattedKey16 = Chaves.ConvertToAlternatingHex(aesKey16);
Console.WriteLine("Chave AES de 32 bytes (alternando uppercase e lowercase):");
Console.WriteLine(formattedKey16);

byte[] aesKey32 = Chaves.GenerateAESKey(32); // 32 bytes = 256 bits, necessário para AES-256

// Exibe a chave em formato hexadecimal
// Converte a chave para hexadecimal com intercalamento de uppercase e lowercase
string formattedKey32 = Chaves.ConvertToAlternatingHex(aesKey32);
Console.WriteLine("Chave AES de 32 bytes (alternando uppercase e lowercase):");
Console.WriteLine(formattedKey32);