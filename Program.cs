using System;
using System.Buffers;

namespace CSharpDataTypesExercises
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ThreeLetterReverse("b","a","t") + "\n");

            Console.WriteLine(LenghtTriangle(6) + "\n");

            //LockoutAfterThreeFailedAttempts();

            Console.WriteLine(Calculator(20, 12, "-") + "\n");

            Console.ReadLine();
        }

        static string ThreeLetterReverse(string a, string b, string c)
        {
            return c + " " + b + " " + a;
        }
        static string LenghtTriangle(int a)
        {
            string result = "";
            for (int i = a; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    result += a.ToString();
                }
                result += "\n";
            }
            return result;
        }
        static void LockoutAfterThreeFailedAttempts()
        {
            string userid = "admin";
            string pass = "admin";
            int attempts = 0;
            while (true)
            {
                if (attempts == 3)
                {
                    Console.WriteLine("No attemtps left.");
                    break;
                }
                Console.WriteLine(3 - attempts + " attemps left.");

                Console.WriteLine("Enter userid");
                string inputuserid = Console.ReadLine();

                Console.WriteLine("Enter pass");
                string inputpass = Console.ReadLine();

                if (inputuserid == userid && inputpass == pass)
                {
                    Console.WriteLine("You're in.");
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong credentials");
                    attempts++;
                }
            }
        }
        static float Calculator(float a, float b, string type)
        {
            switch(type)
            {
                case ("+"):
                    return a + b;
                case ("-"):
                    return a - b;
                case ("*"):
                    return a * b;
                case ("x"):
                    break;
                case ("/"):
                    return a / b;
                default:
                    return 0;
            }
            return 0;
        }
    }
}
