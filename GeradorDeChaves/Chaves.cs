using System;
using System.Security.Cryptography;
using System.Text;

namespace GeradorDeChaves
{
    public static class Chaves
    {
        public static byte[] GenerateAESKey(int keySize)
        {
            byte[] key = new byte[keySize];

            // Usa RandomNumberGenerator para gerar uma chave segura
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(key);
            }

            return key;
        }

        public static string ConvertToAlternatingHex(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 2);
            //string specialChars = "!@#$%^&*()-=+[]{};:<>?";

            for (int i = 0; i < data.Length; i++)
            {
                // Converte o byte para hexadecimal
                string hex = data[i].ToString("X2");

                // Alterna entre uppercase e lowercase
                if (i % 2 == 0)
                    sb.Append(hex.ToUpper()); // Par - Uppercase
                else
                    sb.Append(hex.ToLower());
                //else if (i % 3 == 1)
                //    sb.Append(hex.ToLower()); // Ímpar - Lowercase
                //else
                //    sb.Append(specialChars[i % specialChars.Length]); // Índices com resto 2 - Caractere especial
            }

            return sb.ToString();
        }

        //Chave AES de 32 bytes(alternando uppercase e lowercase) :
        //8C4b0EceE2669C7c26479E0734953850
        //Chave AES de 32 bytes(alternando uppercase e lowercase) :
        //C9a2DBed2FafCA00B56c052965b77BbaA0f419e715b7A7c553faF7d18Aef5Fb7
    }
}
 