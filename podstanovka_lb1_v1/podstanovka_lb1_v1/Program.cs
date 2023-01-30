using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace podstanovka_lb1_v1
{
    class Program
    {
        const string alphabet_origin = "ОПМНХЛИЙЖЗДЕВГАБЮЯЫЭЬ ШЩЦЧФКТУРСЪЁ";
        const string alphabet_coded =  "Z .XY,!ST:;QR&-NOPLMN=PABCDEFGHIJK";
        const string text_origin = "Привет мир";
        public static void print_alphabets()
        {
            for (int i = 0; i < alphabet_coded.Length; i++)
            {
                Console.WriteLine($"|{alphabet_origin[i]}|{(int)alphabet_origin[i]}|{alphabet_coded[i]}|{(int)alphabet_coded[i]}|{(int)alphabet_origin[i] - (int)alphabet_coded[i]}");
            }
        }

        public static string code_string(string text_origin)
        {
            string text_coded = "";
            foreach(char symbol in text_origin)
            {
                string s_symbol = ""+ symbol;
                text_coded += alphabet_coded[alphabet_origin.IndexOf(s_symbol.ToUpper())];
            }
            return text_coded;
        }

        public static string decode_string(string text_coded)
        {
            string text_decoded = "";
            foreach (char symbol in text_coded)
            {
                string s_symbol = "" + symbol;
                text_decoded += alphabet_origin[alphabet_coded.IndexOf(s_symbol.ToUpper())];
            }
            return text_decoded;
        }

        public static void test()
        {
            Console.WriteLine(text_origin);
            string txt = code_string(text_origin);
            Console.WriteLine(txt);

            string decoded_txt = decode_string(txt);
            Console.WriteLine(decoded_txt);
        }
        static void Main(string[] args)
        {

            //print_alphabets();
            test();
            Console.ReadKey();
        }
    }
}
