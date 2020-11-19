using System;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Fucked up calculator";
            double sum = 0;

            Console.WriteLine("Enter your first operator: ");
            char operator1 = Operator();
            Console.WriteLine("Enter your second operator: ");
            char operator2 = Operator();
            double a = Nr();
            double b = Nr();
            double c = Nr();

            //all possible outcomes with 2 operators, 25 possibilities. 

            //TODO  KONTROLLRÄKNA % 

            if (operator1 == '*')
            {
                if (operator2 == '*')
                {
                    sum = a * b * c;
                }
                if (operator2 == '+')
                {
                    sum = a * b + c;
                }
                if (operator2 == '-')
                {
                    sum = a * b - c;
                }
                if (operator2 == '/')
                {
                    sum = a * b / c;
                }
                if (operator2 == '%')
                {
                    sum = a * (b % c);
                }
            }

            if (operator1 == '+')
            {
                if (operator2 == '*')
                {
                    sum = a + b * c;
                }
                if (operator2 == '+')
                {
                    sum = a + b + c;
                }
                if (operator2 == '-')
                {
                    sum = a + b - c;
                }
                if (operator2 == '/')
                {
                    sum = a + b / c;
                }
                if (operator2 == '%')
                {
                    sum = a + (b % c);
                }
            }

            if (operator1 == '-')
            {
                if (operator2 == '*')
                {
                    sum = a - b * c;
                }
                if (operator2 == '+')
                {
                    sum = a - b + c;
                }
                if (operator2 == '-')
                {
                    sum = a - b - c;
                }
                if (operator2 == '/')
                {
                    sum = a - b / c;
                }
                if (operator2 == '%')
                {
                    sum = a - b % c;
                }
            }
            if (operator1 == '/')
            {
                if (operator2 == '*')
                {
                    sum = a / b * c;
                }
                if (operator2 == '+')
                {
                    sum = a / b + c;
                }
                if (operator2 == '-')
                {
                    sum = a / b - c;
                }
                if (operator2 == '/')
                {
                    sum = a / b / c;
                }
                if (operator2 == '%')
                {
                    sum = a / b % c;
                }
            }
            if (operator1 == '%')
            {
                if (operator2 == '*')
                {
                    sum = a % b * c;
                }
                if (operator2 == '+')
                {
                    sum = (a % b) + c;
                }
                if (operator2 == '-')
                {
                    sum = a % b - c;
                }
                if (operator2 == '/')
                {
                    sum = a % b / c;
                }
                if (operator2 == '%')
                {
                    sum = a % b % c;
                }
            }
            Console.WriteLine("{0} {1} {2} {3} {4} = {5} ", a, operator1, b, operator2, c, sum);

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
