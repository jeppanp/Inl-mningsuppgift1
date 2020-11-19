using System;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Fucked up calculator";
            double sum = 0;
            double totalSum = 0;
            bool keepGoing = true;

            do
            {
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
                    else if (operator2 == '+')
                    {
                        sum = a * b + c;
                    }
                    else if (operator2 == '-')
                    {
                        sum = a * b - c;
                    }
                    else if (operator2 == '/')
                    {
                        sum = a * b / c;
                    }
                    else if (operator2 == '%')
                    {
                        sum = a * (b % c);
                    }
                }

                else if (operator1 == '+')
                {
                    if (operator2 == '*')
                    {
                        sum = a + b * c;
                    }
                    else if (operator2 == '+')
                    {
                        sum = a + b + c;
                    }
                    else if (operator2 == '-')
                    {
                        sum = a + b - c;
                    }
                    else if (operator2 == '/')
                    {
                        sum = a + b / c;
                    }
                    else if (operator2 == '%')
                    {
                        sum = a + (b % c);
                    }
                }

                else if (operator1 == '-')
                {
                    if (operator2 == '*')
                    {
                        sum = a - b * c;
                    }
                    else if (operator2 == '+')
                    {
                        sum = a - b + c;
                    }
                    else if (operator2 == '-')
                    {
                        sum = a - b - c;
                    }
                    else if (operator2 == '/')
                    {
                        sum = a - b / c;
                    }
                    else if (operator2 == '%')
                    {
                        sum = a - b % c;
                    }
                }
                else if (operator1 == '/')
                {
                    if (operator2 == '*')
                    {
                        sum = a / b * c;
                    }
                    else if (operator2 == '+')
                    {
                        sum = a / b + c;
                    }
                    else if (operator2 == '-')
                    {
                        sum = a / b - c;
                    }
                    else if (operator2 == '/')
                    {
                        sum = a / b / c;
                    }
                    else if (operator2 == '%')
                    {
                        sum = a / b % c;
                    }
                }
                else if (operator1 == '%')
                {
                    if (operator2 == '*')
                    {
                        sum = a % b * c;
                    }
                    else if (operator2 == '+')
                    {
                        sum = (a % b) + c;
                    }
                    else if (operator2 == '-')
                    {
                        sum = a % b - c;
                    }
                    else if (operator2 == '/')
                    {
                        sum = a % b / c;
                    }
                    else if (operator2 == '%')
                    {
                        sum = a % b % c;
                    }
                }
                Console.WriteLine("{0} {1} {2} {3} {4} = {5} ", a, operator1, b, operator2, c, sum);

                int i1 = 1;
                int i2 = 0;
                
                double[] result = new double[i1];                          // Creating my array that holds the results of each caculation every lap
                result[i2] = sum;
                i1++;

                for (int i = 0; i < result.Length; i++)                     // Adds all the results in to a final sum
                {

                    totalSum = totalSum + result[i];
                }

                if (sum < 100)
                {
                    Console.WriteLine("The sum is less then a hundred");
                }
                else if (sum > 100)
                {
                    Console.WriteLine("The sum is more then a hundred");
                }
                else if (sum == 100)
                {
                    Console.WriteLine("Cool, now you have a hundred, clap clap");
                }
                Console.WriteLine("Antoher try? Enter [Y]es or [N]o");

                do                                                          //This loop is to make sure the program doesnt crasch if user enter wrong key.
                {
                    string continueInString = Console.ReadLine();

                    if (continueInString == "Y" || continueInString == "y")
                    {
                        Console.Clear();                                                        
                        break;                                                                   // Get us out of this inner loop to continue the program
                    }

                    else if (continueInString == "N" || continueInString == "n")   
                    {                                                               
                        Console.WriteLine("Thank you for playing. The sum of all rounds is {0}. Bye", totalSum);
                        keepGoing = false;                                                                    // Changing the bool to false to get out of the loop that runs the program.                           
                        break;                                                                                // Takes us out form this inner loop.
                    }
                    else
                        Console.WriteLine("Please, enter \"Y\" or \"N\" ");
                } while (true);

            } while (keepGoing);

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
