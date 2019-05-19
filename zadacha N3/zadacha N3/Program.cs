using System;

namespace zadacha_N3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string brackets = Console.ReadLine(); 

            int Nbrackets = 0;
            int openningbrackets = 0;
            int closingbrackets = 0;

            bool properbrackets = true;

            

            for (int i = 0; i < brackets.Length; i++)
            {
                if (brackets[i] == '(' || brackets[i] == ')')
                {
                    if (Nbrackets == 0 && brackets[i] == ')')
                    {
                        properbrackets = false;
                        return;
                    } else if (brackets[i] == '(') {
                        Nbrackets++;
                        openningbrackets++;
                    }
                    else if (brackets[i] == ')')
                    {
                        Nbrackets++;
                        closingbrackets++;
                    }
                    if (closingbrackets>openningbrackets)
                    {
                        properbrackets = false;
                    }
                }
            }

            if (closingbrackets != openningbrackets)
            {
                properbrackets = false;
            }

            if (properbrackets == false)
            {
                Console.WriteLine("Improper use of brackets.");
            }
            else if (properbrackets == true)
            {
                Console.WriteLine("Proper use of brackets.");
            }
        }
    }
}
