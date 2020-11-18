using System;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Fucked up calculator";

            Console.WriteLine("Enter your first operator: ");
            var operator1 = Operator();
            Console.WriteLine("Enter your second operator: ");
            char operator2 = Operator();


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

        // User picks a number
        static double Nr()
        {
            double nrInDouble = 0;
            bool myBool = true;
            do
            {
                Console.WriteLine("Enter a number");
                string nrInString = Console.ReadLine();
                try
                {
                    nrInDouble = Convert.ToDouble(nrInString);
                    myBool = false;
                }
                catch
                {
                    Console.WriteLine("Only numbers, please");
                }
            } while (myBool);
            return nrInDouble;
        }

    }
}
