using System;

namespace MethodExerciseProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string favoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite breed?");
            string favoriteBreed = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string favoriteBand = Console.ReadLine();

            Console.WriteLine("Why is this your favorite band?");
            string favoriteBandReason = Console.ReadLine();

            Console.WriteLine($"I'd like to introduce myself and tell you a little more about me.");
            Console.WriteLine($"I am a proud TrueCoders student. My name is {userName}");
            Console.WriteLine($"My favorite color is {favoriteColor}, {favoriteColor} on {favoriteColor} on {favoriteColor}.");
            Console.WriteLine($"My favorite animal is a {favoriteAnimal}. We have 2 {favoriteBreed} named Winnie and Jack");
            Console.WriteLine($"My favorite band is {favoriteBand} because {favoriteBandReason}.");

            Console.WriteLine("Please enter your first addend:");
            int add1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter an 2nd addend:");
            int add2 = int.Parse(Console.ReadLine());

            int sum = Sum(add1, add2);
            Console.WriteLine($"The sum is {sum}");

            Console.WriteLine("Please enter a multiplicand:");
            int mul1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a mulitplier:");
            int mul2 = int.Parse(Console.ReadLine());

            int Product = (mul1 * mul2);
            Console.WriteLine($"The product is {Product}");

            Console.WriteLine("Please enter a minuend:");
            int sub1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a subtrahend:");
            int sub2 = int.Parse(Console.ReadLine());

            int Difference = (sub1 - sub2);
            Console.WriteLine($"The difference is {Difference}");

            Console.WriteLine("Please enter a dividend:");
            int div1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a divisor:");
            int div2 = int.Parse(Console.ReadLine());

            int Quotient = (div1 / div2);
            Console.WriteLine($"The quotient is {Quotient}");

            Console.WriteLine("Please enter a dividend:");
            int mod1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a divisor:");
            int mod2 = int.Parse(Console.ReadLine());

            int Rem = (mod1 % mod2);
            Console.WriteLine($"The remainder is {Rem}");
        }

        public static int Sum(int add1, int add2)
        {
            return add1 + add2;
        }

        public static int Multiply(int mul1, int mul2)
        {
            return mul1 * mul2;
        }
        public static int Subtract(int sub1, int sub2)
        {
            return sub1 - sub2;
        }
        public static int Divide(int div1, int div2)
        {
            return div1 / div2;
        }
        public static int Modulo(int mod1, int mod2)
        {
            return mod1 % mod2;
        }

    }
}
