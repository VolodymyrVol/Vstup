using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Vstup
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
           
        static void Task1(int number)
        {
            if (number < 1 || number > 100)
            {
                Console.WriteLine("err");
            }
            else
            {
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }

        static void Task2(double number, double percent)
        {
            double result = (number * percent) / 100;
            Console.WriteLine($"{percent}% от {number} равно {result}");
        }

        static void Task3(int a, int b, int c, int d)
        {
            string res = "";
            res += a;
            res += b;
            res += c;
            res += d;
            Console.WriteLine($"result {res}");
        }

        static void Task4(string number)
        {
            if (number.Length != 6)
            {
                Console.WriteLine("err");
            }
            else
            {
                Console.WriteLine("Введите номера разрядов для обмена (от 1 до 6):");
                int pos1 = int.Parse(Console.ReadLine()) - 1;
                int pos2 = int.Parse(Console.ReadLine()) - 1;

                char[] digits = number.ToCharArray();
                char temp = digits[pos1];
                digits[pos1] = digits[pos2];
                digits[pos2] = temp;

                string result = new string(digits);
                Console.WriteLine($"res: {result}");
            }
        }

        static void Task5(double temperature)
        {
            Console.WriteLine("1: F -> C \n 2: C -> F");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                double celsius = (temperature - 32) * 5 / 9;
                Console.WriteLine($"C: {celsius}");
            }
            else if (choice == 2)
            {
                double fahrenheit = (temperature * 9 / 5) + 32;
                Console.WriteLine($"F: {fahrenheit}");
            }
            else
            {
                Console.WriteLine("err");
            }
        }

        static void Task6(int num1, int num2)
        {
            int start = Math.Min(num1, num2);
            int end = Math.Max(num1, num2);

            Console.WriteLine($"Четные числа в диапазоне от {start} до {end}:");
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
