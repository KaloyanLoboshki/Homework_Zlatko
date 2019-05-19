using System;

namespace zandachaN8page106___5
{
    class Program
    {
        static void Swap(string[] masiv,int a ,int b) {
            string c = masiv[a];
            masiv[a] = masiv[b];
            masiv[b] = c;
        }

        static void Main(string[] args)
        {
            string[] masiv = { "red", "blue", "white", "white", "white", "red", "red", "blue", "blue", "white", "white", "red", "white", "blue", "red", "blue", "white", "red" };

            for (int i = 0; i < masiv.Length; i++)
            {
                Console.Write(masiv[i]+" ");
            }
            Console.WriteLine();

            int redpointer = 0;
            int whitepointer = masiv.Length - 1;

            for (int i = 0; i < whitepointer+1; i++)
            {
                if (masiv[i] == "red" && i == redpointer)
                {
                    redpointer++;
                } else if (masiv[i] == "red" && i != redpointer)
                {
                    Swap(masiv, i, redpointer);
                    redpointer++;
                }
                else if (masiv[i] == "white" && masiv[whitepointer] == "white")
                {
                    i--;
                    whitepointer--;
                } else if (masiv[i] == "white" && masiv[whitepointer] != "white") {
                    Swap(masiv, i, whitepointer);
                    whitepointer--;
                    i--;
                }
                
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < masiv.Length; i++)
            {
                Console.Write(masiv[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
