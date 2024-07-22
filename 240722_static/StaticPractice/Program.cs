using System.Numerics;

namespace StaticPractice
{
    internal class Program
    {
        public class MyCalculator
        {
            public double x;
            public double y;

            public void SelectNum()
            {
                Console.Write("연산할 첫번재 숫자를 입력해주세요 : ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("연산할 두번재 숫자를 입력해주세요 : ");
                double.TryParse(Console.ReadLine(), out y);
            }

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

            public void PrintInfo()
            {
                Console.WriteLine($"덧셈 결과 : {Add(x, y)}");
                Console.WriteLine($"뺄셈 결과 : {Subtract(x, y)}");
                Console.WriteLine($"곱셈 결과 : {Multiply(x, y)}");
                Console.WriteLine($"나눗셈 결과 : {Divide(x, y)}");
                Console.WriteLine($"거듭제곱 결과 : {Squared(x, y)}");
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
