using System;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Fucked up calculator";

            Console.WriteLine("Enter your first operator: ");


        }


        // User choice for an operator 
        static char Operator()
        {
            char operantInChar = '0';
            bool myBool = true;
            do
            {
                string operatorInString = Console.ReadLine();
                if (operatorInString == "*" || operatorInString == "/" || operatorInString == "-" || operatorInString == "+" || operatorInString == "%")
                {
                    try
                    {
                        operantInChar = Convert.ToChar(operatorInString);

                        myBool = false;
                    }
                    catch
                    {
                        Console.WriteLine("Please try to enter an operant /, *, +, -, %");

                    }
                }
                else
                {
                    Console.WriteLine("You can only choose between \"+, - , * , / , %\" ");
                }
            } while (myBool);
            return operantInChar;
        }
    }
}
