using System;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Fucked up calculator";
            double sum;
            double finalResult = 0;
            bool keepGoing = true;
            int i1 = 1;
            int i2 = 0;


            do
            {
                Console.WriteLine("Enter your first operator: ");
                char operator1 = SelectOperator();
                Console.WriteLine("Enter your second operator: ");
                char operator2 = SelectOperator();
                double a = SelectNr();
                double b = SelectNr();
                double c = SelectNr();
                sum = Calculator(a, b, c, operator1, operator2);

                Console.WriteLine("{0} {1} {2} {3} {4} = {5} ", a, operator1, b, operator2, c, sum);

                double[] result = new double[i1];
                result[i2] = sum;
                i1++;
                i2++;
                finalResult = TotalSum(result, finalResult);

                SumMoreOrLessThenHundred(sum);

                keepGoing = WannaGoAgain(finalResult, keepGoing);
            } while (keepGoing);

        }

        static bool WannaGoAgain(double totalSum, bool keepGoing)
        {
            Console.WriteLine("Antoher try? Enter [Y]es or [N]o");

            do                                                          //This loop is to make sure the program doesnt crasch if user enter wrong key.
            {
                string continueInString = Console.ReadLine();

                if (continueInString == "Y" || continueInString == "y")
                {
                    Console.Clear();
                    return keepGoing;                                                                   // Get us out of this inner loop to continue the program
                }

                else if (continueInString == "N" || continueInString == "n")
                {
                    Console.WriteLine("Thank you for playing. The sum of all rounds is {0}. Bye", totalSum);
                    keepGoing = false;
                    return keepGoing;                                                                                        // Changing the bool to false to get out of the loop that runs the program.                           
                                                                                                                             // Takes us out form this inner loop.
                }
                else
                    Console.WriteLine("Please, enter \"Y\" or \"N\" ");
            } while (true);
        }

        static void SumMoreOrLessThenHundred(double sum)
        {
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
        }
        static double TotalSum(double[] result, double finalResult)
        {

            for (int i = 0; i < result.Length; i++)                     // Adds all the results in to a final sum
            {

                finalResult = finalResult + result[i];
            }
            return finalResult;
        }

        //all possible outcomes with 2 operators, 16 possibilities. 
        static double Calculator(double a, double b, double c, char operator1, char operator2)
        {
            double sum = 0;
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
            }
            return sum;
        }


        static char SelectOperator()
        {
            char operantInChar = '0';
            bool myBool = true;
            do
            {
                string operatorInString = Console.ReadLine();
                if (operatorInString == "*" || operatorInString == "/" || operatorInString == "-" || operatorInString == "+")
                {
                    try
                    {
                        operantInChar = Convert.ToChar(operatorInString);

                        myBool = false;
                    }
                    catch
                    {
                        Console.WriteLine("You can only choose between \"+, - , * , /\"");

                    }
                }
                else
                {
                    Console.WriteLine("You can only choose between \"+, - , * , /\"");
                }
            } while (myBool);
            return operantInChar;
        }


        static double SelectNr()
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
