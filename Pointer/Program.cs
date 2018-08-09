using System;

namespace Pointer
{
    unsafe class Program
    {
        public static void Main(string[] args)
        {
            int a = 3;
            Console.WriteLine(a);
            Console.WriteLine((int)&a);

            Console.WriteLine();

            int* a_ptr = &a;
            Console.WriteLine((int)a_ptr);
            Console.WriteLine(*a_ptr);
            Console.WriteLine((int)&a_ptr);

            Console.WriteLine();

            Console.WriteLine(Funtion1(a));
            Console.WriteLine(a);

            Console.WriteLine();

            Console.WriteLine(Funtion2(&a));
            Console.WriteLine(a);

            Console.WriteLine();

            Console.ReadKey();
        }

        static int Funtion1(int a)
        {
            return ++a;
        }

        static int Funtion2(int* a)
        {
            return ++*a;
        }
    }
}
