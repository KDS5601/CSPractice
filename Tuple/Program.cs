using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("두 숫자 입력");
            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);

            (int sum, int muti) Mytuble1 = MyTupleFuntion(a, b);

            Console.WriteLine(Mytuble1.sum);
            Console.WriteLine(Mytuble1.muti);

            Console.WriteLine("두 숫자 입력");
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);

            (int sum, int muti) = MyTupleFuntion(a, b);
            Console.WriteLine(sum);
            Console.WriteLine(muti);;

            Console.ReadKey();
        }

        static (int sum, int muti) MyTupleFuntion(int a, int b)
        {
            return (a + b, a * b);
        }
    }
}
