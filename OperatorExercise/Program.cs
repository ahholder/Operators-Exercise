using System.Transactions;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args) //All Exercises
        {
            //Console.WriteLine("Hello, World!");
            string answ = ""; bool checkLoop = false;
            do
            {
                Console.WriteLine("Would you the simplified version of these exercises (yes/no)?");
                answ = Console.ReadLine();
                if (answ == "yes" || answ == "no")
                {
                    checkLoop = true;
                }
                else
                {
                    Spacer();
                    Console.WriteLine("Please enter a valid response!");
                    Spacer();
                }
            } while (checkLoop == false);
            if (answ == "no")
            {
                Exercise1();
                Exercise2();
                Spacer();
            } else
            {
                CombinedExercises();
            }
        }
        static void Spacer()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }

        //Exercise #1 - Full

        static void Exercise1()
        {
            string answ = ""; int a = 0; int b = 0; bool looping = true; bool checkLoop = false; int quotient = 0; int remainder = 0;
            Spacer();
            Console.WriteLine("Exercise #1: A Simple Program to Give the Results of Addition, Subtraction, Multiplication, Division, and Modulus");
            do
            {
                //Basic Setup
                answ = "";
                checkLoop = false;
                Spacer();

                //Get Numbers
                Console.WriteLine("Please give a number:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Please give another number:");
                b = int.Parse(Console.ReadLine());
                //Run Operations
                Spacer();
                AddE1(a, b);
                SubtractE1(a, b);
                MultiplyE1(a, b);
                FullDivisionE1(a, b);

                //Former Operations - Prototype Code, Unused
                /*quotient = DivideE1(a, b);
                remainder = ModulusE1(a, b);
                Console.WriteLine("Addition: " + AddE1(a, b));
                Console.WriteLine("Subtraction: " + SubtractE1(a, b));
                Console.WriteLine("Multiplication: " + MultiplyE1(a, b));
                //Console.WriteLine($"Division: {quotient}");
                //Console.WriteLine($"Modulus: {remainder}");
                Console.WriteLine($"Division: {a}/{b} is {quotient} remainder {remainder}");*/

                //Check Continuation
                do
                {
                    Spacer();
                    Console.WriteLine("Would you like to perform another operation (yes/no)?");
                    answ = Console.ReadLine();
                    if (answ == "yes" || answ == "no")
                    {
                        checkLoop = true;
                    } else
                    {
                        Spacer();
                        Console.WriteLine("Please enter a valid response!");
                    }
                } while (checkLoop == false);
                if (answ == "no") looping = false;
            } while (looping == true);
            Spacer();
        }
        static int AddE1(int a, int b)
        {
            int c = a + b;
            Console.WriteLine($"{a} + {b} is {c}");
            return c;
        }
        static int SubtractE1(int a, int b)
        {
            int c = a - b;
            Console.WriteLine($"{a} - {b} is {c}");
            return c;
        }
        static int MultiplyE1(int a, int b)
        {
            int c = a * b;
            Console.WriteLine($"{a} * {b} is {c}");
            return c;
        }
        static void FullDivisionE1(int a, int b)
        {
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
        }
        static int DivideE1(int a, int b) //Prototype, Unused
        {
            int c = a / b;
            Console.WriteLine($"{a} / {b} is {c}");
            return c;
        }
        static int ModulusE1(int a, int b) //Prototype, Unused
        {
            int c = a % b;
            Console.WriteLine($"{a} % {b} is {c}");
            return c;
        }

        //Exercise #2 - Full

        static void Exercise2()
        {
            string answ = ""; bool looping = true; bool checkLoop = false; double radius = 0.0; double result = 0.0;
            Console.WriteLine("Exercise #2: Return the Area of a Circle Based on Radius");
            do
            {
                //Basic Setup
                answ = "";
                checkLoop = false;
                Spacer();

                //Get Numbers
                Console.WriteLine("Please the radius:");
                radius = double.Parse(Console.ReadLine());
                //Run Operations
                Spacer();
                result = Math.PI * Math.Pow(radius, 2);
                Console.WriteLine($"The area of a circle with a radius of {radius} is {result}");

                //Check Continuation
                do
                {
                    Spacer();
                    Console.WriteLine("Would you like to perform another operation (yes/no)?");
                    answ = Console.ReadLine();
                    if (answ == "yes" || answ == "no")
                    {
                        checkLoop = true;
                    }
                    else
                    {
                        Spacer();
                        Console.WriteLine("Please enter a valid response!");
                    }
                } while (checkLoop == false);
                if (answ == "no") looping = false;
            } while (looping == true);
            Spacer();
        }

        //Exercise #1 & #2 - Simplified

        static void CombinedExercises()
        {
            int a = 0; int b = 0; double radius = 0.0; double result = 0.0;
            Spacer();

            //Exercise # 1
            Console.WriteLine("Please give a number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Please give another number:");
            b = int.Parse(Console.ReadLine());
            FullDivisionE1(a, b);

            //Exercise # 2
            Console.WriteLine("What is the radius of your circle?");
            radius = double.Parse(Console.ReadLine());
            result = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of a circle with a radius of {radius} is {result}");
        }
    }
}
