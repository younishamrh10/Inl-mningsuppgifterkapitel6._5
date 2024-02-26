using System;

namespace Inlämningsuppgifterkapitel6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Längst meddelande mellan \"hejjagheteryounis\" och \"hejjagheter\" är" + Längst("hejjagheteryounis", "hejjagheter"));
            Console.WriteLine("Längsta numret mellan \"12345\" och \"123456789\" är" Längst(12345, 123456789));
        }

        static int Längst(int tal1, int tal2)
        {
            if (tal1.ToString().Length > tal2.ToString().Length)
            {
                return tal1;
            }

            else if (tal1.ToString().Length < tal2.ToString().Length)
            {
                return tal2;
            }

            else
            {
                return tal1;
            }
        }

        static string Längst(string text1, string text2)
        {
            if (text1.Length > text2.Length)
            {
                return text1;
            }

            else if (text1.Length > text2.Length)
            {
                return text2;
            }

            else
            {
                return text1;
            }
        }
    }
}