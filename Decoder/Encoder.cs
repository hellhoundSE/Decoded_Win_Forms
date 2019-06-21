using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoder
{
    class Encoder
    {
        public static char[] characters = new char[] {
                                                'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i',
                                                'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                                                's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A',
                                                'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
                                                'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S',
                                                'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' ', '0',
                                                '1', '2', '3', '4', '5', '6', '7', '8', '9'
                                                };



        public static string encode2(string word, string key)
        {

            string result = "";
            int key_index = 0;
            char[] arr = key.ToCharArray();

            foreach(char symbol in word)
            {
                int c = symbol + arr[key_index];
                Console.WriteLine("c " + c);

                while(c > 122)
                    c = 48 + (c % 123);
                Console.WriteLine("c " + c);

                Console.WriteLine("symbol " + (int)symbol);
                Console.WriteLine("key_index " + (int)arr[key_index]);
                Console.WriteLine();

                result += (char)c;


                key_index++;
                if (key_index == key.Length)
                    key_index = 0;
            }

            return result;
        }

        public static string decode2(string word, string key)
        {
            string result = "";
            int key_index = 0;
            char[] arr = key.ToCharArray();


            foreach (char symbol in word)
            {
                String cc = (123 - 47) - (arr[key_index]-48)+"";
                cc = encode(symbol+"", cc);
               
                result += cc;


                key_index++;
                if (key_index == key.Length)
                    key_index = 0;
            }
            return result;
        }

        public static string encode(string word, string key)
        {
            String result="";

            int key_index = 0;
            char[] arr = key.ToCharArray();

            foreach (char symbol in word)
            {
                
                int dif = findIndex(arr[key_index]);
                int beg = findIndex(symbol);

                int encoded = dif+beg;

                if (encoded >= characters.Length)
                {
                    encoded %= characters.Length;
                }

                result += characters[encoded];

                key_index++;
                if (key_index == key.Length)
                    key_index = 0;
            }

            return result;
        }

        public static string decode(string word, string key)
        {
            String result = "";

            int key_index = 0;
            char[] arr = key.ToCharArray();

            foreach (char symbol in word)
            {

                int dif = findIndex(arr[key_index]);
                int beg = findIndex(symbol);

                int encoded = beg - dif;

                if (encoded < 0)
                {
                    encoded = characters.Length + encoded;
                }

                result += characters[encoded];

                key_index++;
                if (key_index == key.Length)
                    key_index = 0;
            }

            return result;
        }




        public static int findIndex(char c)
        {
            for(int i = 0;i < characters.Length; i++)
                if (c == characters[i])
                    return i;
            return -1;
        }
    }
}
