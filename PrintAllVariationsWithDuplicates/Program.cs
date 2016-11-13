using System;

namespace PrintAllVariationsWithDuplicates
{
    class Program
    {
        static int maxElementValue;
        static int numberOfElements;
        static int[] variation;


        static void Main(string[] args)
        {
            Console.Write("Input largest number available in the variation: ");
            maxElementValue = GetInteger();

            Console.Write("Input the size of the variations: ");
            numberOfElements = GetInteger();

            variation = new int[numberOfElements];

            PrintVariation(0);
        }

        static int GetInteger()
        {
            string input;
            bool isParsed = false;
            int output = 0;

            while (!isParsed)
            {
                Console.Write("Enter an integer: ");

                input = Console.ReadLine();

                isParsed = int.TryParse(input, out output);

                if (!isParsed)
                {
                    Console.Write("Invalid entry. ");
                }
            }

            return output;
        }

        static void PrintArray(int[] array)
        {
            int lastIndex = array.Length - 1;

            Console.Write("(");

            for (int i = 0; i < lastIndex; i++)
            {
                Console.Write(" {0}", array[i]);
            }

            Console.Write(" " + array[lastIndex] + " )");

            Console.WriteLine();
        }

        static void PrintVariation(int indexInVariation)
        {
            if (indexInVariation + 1 == numberOfElements)
            {
                for (int i = 0; i < maxElementValue; i++)
                {
                    variation[indexInVariation] = i + 1;
                    PrintArray(variation);
                }

                return;
            }

            for (int i = 0; i < maxElementValue; i++)
            {
                variation[indexInVariation] = i + 1;
                PrintVariation(indexInVariation + 1);
            }
        }
    }
}
