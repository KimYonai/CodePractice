using System.Numerics;

namespace StaticPractice
{
    internal class Program
    {
        class MyCalculator
        {
            static double Add(double x, double y)
            {
                return x + y;
            }

            static double Subtract(double x, double y)
            {
                return x - y;
            }

            static double Multiply(double x, double y)
            {
                return x * y;
            }

            static double Divide(double x, double y)
            {
                if (y == 0)
                {
                    Console.WriteLine("0으로 나눌 수 없습니다. 다른 수를 입력해주세요");
                }

                return x / y;
            }

            static double Squared(double x, double y)
            {
                double result = 1.0;

                for (int i = 0; i <= y; i++)
                {
                    result *= x;
                }

                return result;
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
