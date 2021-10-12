using System;

namespace Lab3_Crypto_Vernam_Cipher
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ExampleEng();
            ExampleRus();
        }


        static void ExampleEng()
        {
            Console.WriteLine("---English encoder example---");
            string text = "hello";
            var alg = new VernamCoder(text);
            string encoded = alg.Encode();
            string decoded = new VernamCoder(encoded).Encode();
            Console.WriteLine("Text: {0}", text);
            Console.WriteLine("Encrypt: {0}", encoded);
            Console.WriteLine("Decrypt: {0}", decoded);
        }

        static void ExampleRus()
        
        {
            Console.WriteLine("---Пример русского кодировщика---");
            string text = "вышел грека через реку видит грека в реке рак";
            var alg = new VernamCoder(text);
            string encoded = alg.Encode();
            string decoded = new VernamCoder(encoded).Encode();
            Console.WriteLine("Текст: {0}", text);
            Console.WriteLine("Зашифрованный текст: {0}", encoded);
            Console.WriteLine("Расшифрованный текст: {0}", decoded);
        }
        
        
    }
}