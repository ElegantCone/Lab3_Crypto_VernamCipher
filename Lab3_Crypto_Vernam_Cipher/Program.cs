using System;
using System.Text;

namespace Lab3_Crypto_Vernam_Cipher
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Введите текст: ");
            text = Console.ReadLine();
            Encode(text);
            //ExampleEng();
            //ExampleRus();
        }


        static void ExampleEng()
        {
            Console.WriteLine("---English encoder example---");
            string text = "hello";
            Encode(text);
        }

        static void ExampleRus()
        {
            Console.WriteLine("---Пример русского кодировщика---");
            string text = "вышел грека через реку видит грека в реке рак";
            Encode(text);
        }

        static void Encode(string text)
        {
            var alg = new VernamCoder(text);
            string encoded = alg.Encode();
            string decoded = new VernamCoder(encoded).Encode();
            Console.WriteLine("Текст: {0}", text);
            Console.WriteLine("Зашифрованный текст: {0}", encoded);
            Console.WriteLine("Расшифрованный текст: {0}", decoded);
        }
    }
}