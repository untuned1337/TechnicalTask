using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCorrect_1
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoCorrect("I donn’t knoow pii value, so I will go eat my ppiie…");
            Console.ReadKey();
        }

        public static void AutoCorrect(string input)
        {
            string noAdjDup = RemoveDuplicateAdjacent(input);
            string piReplaced = ReplacePi(noAdjDup);
            Console.WriteLine(piReplaced);
        }

        public static string ReplacePi(string input)
        {
            string[] inputParts = input.Split(new string[] { " pi " }, StringSplitOptions.None);
            string result = "";

            for (int i = 0; i < inputParts.Length; i++)
            {
                result += inputParts[i];
                if (i != inputParts.Length - 1)
                {

                    result += " 3.14 ";
                }
            }
            return result;
        }

        public static string RemoveDuplicateAdjacent(string input)
        {
            if (input.Length == 0)
                return "";
            string result = "";
            result += input[0];

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    result += input[i];
                }
                else if (!Char.IsLetter(input[i]))
                {
                    result += input[i];
                }
            }

            return result;
        }
    }
}
